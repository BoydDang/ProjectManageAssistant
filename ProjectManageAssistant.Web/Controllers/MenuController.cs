using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.Web.Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class MenuController : BaseController
    {
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public IMenuBLL menuBLL { get; set; }
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuList()
        {
            var list = menuBLL.GetList("");
            return PartialView("/views/shared/_MenuInfo.cshtml", list);
        }
    }
}