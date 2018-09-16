using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class PlanController : BaseController
    {
        // GET: Plan
        public ActionResult Index()
        {
            ViewBag.PageTitle = "计划记录";
            return View();
        }
    }
}