using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class GoodsController : BaseController
    {
        // GET: Goods
        public ActionResult Index()
        {
            ViewBag.PageTitle = "物资记录";
            return View();
        }
    }
}