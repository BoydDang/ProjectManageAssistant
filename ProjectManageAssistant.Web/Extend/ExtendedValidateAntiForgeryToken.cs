﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Extend
{
    public class ExtendedValidateAntiForgeryToken : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
            if (request.HttpMethod != WebRequestMethods.Http.Post) return;
            if (request.IsAjaxRequest())
            {
                var antiForgeryCookie = request.Cookies[AntiForgeryConfig.CookieName];
                var cookieValue = antiForgeryCookie != null ? antiForgeryCookie.Value : null;
                //从cookies 和 Headers 中 验证防伪标记
                //这里可以加try-catch
                try
                {
                    AntiForgery.Validate(cookieValue, request.Headers["__RequestVerificationToken"]);
                }
                catch
                {
                }
            }
            else
            {
                new ValidateAntiForgeryTokenAttribute().OnAuthorization(filterContext);
            }
        }

    }
}