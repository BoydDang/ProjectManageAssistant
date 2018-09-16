using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class MaterialController : BaseController
    {
        // GET: Material
        public ActionResult Index()
        {
            ViewBag.PageTitle = "材料记录";
            return View();
        }
    }
}