using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class ProjectController : BaseController
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WorkNote()
        {
            ViewBag.PageTitle = "日志记录";
            return View();
        }

        public ActionResult Purchase()
        {
            ViewBag.PageTitle = "采购记录";
            return View();
        }
    }
}