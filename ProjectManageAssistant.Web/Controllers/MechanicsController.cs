using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class MechanicsController : BaseController
    {
        // GET: Mechanics
        public ActionResult Index()
        {
            ViewBag.PageTitle = "机械记录";
            return View();
        }
    }
}