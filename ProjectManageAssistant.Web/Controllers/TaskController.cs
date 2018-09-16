using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class TaskController : BaseController
    {
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TaskSummary()
        {
            ViewBag.PageTitle = "任务记录";
            return View();
        }
    }
}