﻿using System.Web;
using System.Web.Mvc;

namespace WebSite_FormValidacao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
