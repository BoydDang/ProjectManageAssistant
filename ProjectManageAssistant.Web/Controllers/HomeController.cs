using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class HomeController : BaseController
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
    }
}