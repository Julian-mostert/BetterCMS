﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtmlAttributesUtility.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BetterCms.Module.Root.Mvc.Extensions
{
    internal static class HtmlAttributesUtility
    {
        // Methods
        public static IDictionary<string, object> ObjectToHtmlAttributesDictionary(object htmlAttributes)
        {
            IDictionary<string, object> dictionary = null;
            if (htmlAttributes == null)
            {
                return new Dictionary<string, object>();
            }
            dictionary = htmlAttributes as IDictionary<string, object>;
            if (dictionary == null)
            {
                dictionary = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes).FixHtmlAttributes();
            }
            return dictionary;
        }

        public static Dictionary<string, object> FixHtmlAttributes(this IDictionary<string, object> htmlAttributes)
        {
            var keysToRemove = new List<string>();
            var newAttributes = new Dictionary<string, object>();
            foreach (var attr in htmlAttributes)
            {
                var converted = attr.Key.CamelToDash();

                keysToRemove.Add(attr.Key);
                newAttributes.Add(converted, attr.Value);
            }
            return newAttributes;
        }
    }
}