using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class CostAnalysisController : BaseController
    {
        // GET: CostAnalysis
        public ActionResult Index()
        {
            ViewBag.PageTitle = "成本分析";
            return View();
        }
    }
}