﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanXeDap2.Common;
using System.Web.Routing;

namespace BanXeDap2.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            if(session==null)
            {
                filterContext.Result = new RedirectToRouteResult(new 
                    RouteValueDictionary(new { controller="Login", action="Index", Area="Admin"}));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}