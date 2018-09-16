using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class SystemExceptionController : BaseController
    {
        // GET: SystemException
        public ActionResult Index()
        {
            ViewBag.PageTitle = "系统异常";
            return View();
        }

        public ActionResult Error()
        {
            BaseException ex = new BaseException();
            return View(ex);
        }
    }
}