﻿using System.Web;
using System.Web.Mvc;

namespace Exercise30_9_15
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
