﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

using BetterCms.Core.DataContracts;
using BetterCms.Core.Modules.Projections;
using BetterCms.Module.Pages.Models;
using BetterCms.Module.Root.ViewModels.Cms;

using Common.Logging;

namespace BetterCms.Module.Pages.Accessors
{
    [Serializable]
    public class ServerControlWidgetAccessor : ContentAccessor<ServerControlWidget>
    {
        private static readonly ILog logger = LogManager.GetCurrentClassLogger();

        public ServerControlWidgetAccessor(ServerControlWidget content, IList<IOption> options)
            : base(content, options)
        {
        }

        /// <summary>
        /// Gets the contents of the partial view.
        /// </summary>
        /// <param name="partialViewName">The name of the partial view.</param>
        /// <param name="html">The HTML helper.</param>
        /// <returns>Contents of the partial view</returns>
        private string GetPartialViewContent(string partialViewName, HtmlHelper html)
        {
            try
            {
                ViewEngineResult partialView = ViewEngines.Engines.FindPartialView(html.ViewContext, partialViewName);
                IView view = partialView.View;

                if (view == null)
                {
                    return GetErrorString(partialViewName, "View not found");
                }

                using (var sw = new StringWriter())
                {
                    var viewData = new ViewDataDictionary();

                    if (Options != null && Options.Count > 0)
                    {
                        foreach (var option in Options)
                        {
                            if (option.Value != null)
                            {
                                viewData[option.Key] = option.Value;
                            }                             
                        }
                    }

                    viewData["bcmsPageId"] = html.ViewContext.ViewData["pageId"];

                    var newViewContext = new ViewContext(html.ViewContext, view, viewData, html.ViewContext.TempData, sw);
                    try
                    {
                        newViewContext.ViewData.Model = new WigetViewModel()
                            {
                                Page = (IPage)html.ViewData.Model,
                                Widget = Content
                            };
                        view.Render(newViewContext, sw);
                    }
                    catch (InvalidOperationException ex)
                    {
                        logger.Warn(
                            string.Format(
                                "Server widget \"{0}\" rendering failed. Check if widget view model is BetterCms.Module.Root.ViewModels.Cms.WigetViewModel", GetTitle()),
                            ex);
                        newViewContext.ViewData.Model = null;
                        view.Render(newViewContext, sw);
                    }

                    return sw.GetStringBuilder().ToString();
                }
            }
            catch (Exception e)
            {
                return GetErrorString(partialViewName, e.Message);
            }
        }

        public override string GetContentWrapperType()
        {
            return "server-widget";
        }

        public override string GetHtml(HtmlHelper html)
        {
            var text = GetPartialViewContent(Content.Url, html);

            if (!string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            return "&nbsp;";
        }

        public override string GetCustomStyles(HtmlHelper html)
        {
            return null;
        }

        public override string GetCustomJavaScript(HtmlHelper html)
        {
            return null;
        }

        //
        // TODO: Error view ???
        //
        private static string GetErrorString(string view, string message)
        {
            return string.Format(@"<div class=""bcms-error"">Error rendering view ""{0}"": {1}</div>", view, message);
        }
    }
}