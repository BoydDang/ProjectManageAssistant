using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class WorkerController : BaseController
    {
        // GET: Worker
        public ActionResult Index()
        {
            ViewBag.PageTitle = "记工记录";
            return View();
        }
    }
}