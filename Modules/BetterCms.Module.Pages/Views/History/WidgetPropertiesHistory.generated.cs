﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/History/WidgetPropertiesHistory.cshtml")]
    public partial class _Views_History_WidgetPropertiesHistory_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.History.HtmlContentWidgetHistoryViewModel>
    {
        public _Views_History_WidgetPropertiesHistory_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 5 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.HtmlContentWidget_ContentName_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n        <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 7 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
       Write(Html.TextBoxFor(model => model.Name, new { @readonly = "readonly", @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.HtmlContentWidget_CustomHTML_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-poptext-editor-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
       Write(Html.TextAreaFor(model => model.Html, new { @readonly = "readonly", @class = "bcms-advanced-contenthtml bcms-editor-field-area bcms-code-field" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
       Write(Html.CheckBoxFor(model => model.UseCustomHtml, new { @disabled = "disabled" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 21 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
                                    Write(Html.Raw(PagesGlobalization.HtmlContentWidget_RenderCustomHTML_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.HtmlContentWidget_CustomCSS_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 27 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
   Write(Html.TextAreaFor(model => model.CustomCss, new { @readonly = "readonly", @class = "bcms-editor-field-area bcms-code-field bcms-code-field-css" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
       Write(Html.CheckBoxFor(model => model.UseCustomCss, new { @disabled = "disabled" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
                                    Write(Html.Raw(PagesGlobalization.HtmlContentWidget_RenderCustomCSS_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
                                    Write(PagesGlobalization.HtmlContentWidget_CustomJS_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 39 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
   Write(Html.TextAreaFor(model => model.CustomJs, new { @readonly = "readonly", @class = "bcms-editor-field-area bcms-code-field bcms-code-field-javascript" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
       Write(Html.CheckBoxFor(model => model.UseCustomJs, new { @disabled = "disabled" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\History\WidgetPropertiesHistory.cshtml"
                                    Write(Html.Raw(PagesGlobalization.HtmlContentWidget_RenderCustomJS_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
