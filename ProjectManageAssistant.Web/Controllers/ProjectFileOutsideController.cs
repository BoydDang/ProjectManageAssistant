using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class ProjectFileOutsideController : BaseController
    {
        // GET: ProjectFileOutside
        public ActionResult Index()
        {
            return View();
        }
    }
}