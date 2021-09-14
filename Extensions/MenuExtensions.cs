using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using AdminLte.Core.Starter.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace AdminLte.Core.Starter.Extensions
{
    public static class MenuExtensions
    {
        public static bool IsPageActive(this IHtmlHelper htmlHelper, string pageUrl)
        {
            var viewContext = htmlHelper.ViewContext;
            var currentPageUrl = viewContext.RouteData.Values["page"].ToString();
            //var currentPageUrl = viewContext.ViewData["ActiveMenu"] as string ?? viewContext.HttpContext.Request.Path;
            //return currentPageUrl.StartsWith(pageUrl, StringComparison.OrdinalIgnoreCase);
            return currentPageUrl.Equals(pageUrl.Split("?")[0], StringComparison.OrdinalIgnoreCase);
        }
        public static bool IsPageActive(this IHtmlHelper htmlHelper, params string[] pages)
        {
            var addMenuOpenTag = pages.Length > 1;
            var isActive = pages.Aggregate(false, (current, page) => current || htmlHelper.IsPageActive(page));

            return isActive;
        }

        public static string SetActiveIfOnPage(this IHtmlHelper htmlHelper, params string[] pages)
        {
            var addMenuOpenTag = pages.Length > 1;
            var isActive = htmlHelper.IsPageActive(pages);

            return isActive ? (addMenuOpenTag?"menu-open":"active") : "";
        }

        public static List<string> GetSubitemsPaths(MenuItem menuItem)
        {
            var list = new List<string>();

            if (menuItem.Subitems != null) list.AddRange(menuItem.Subitems.Select(subItem => subItem.PageUrl));

            return list;
        }
    }
}
