using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.Web.Extend;
using System.Web.Mvc;
using Unity.Attributes;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class SystemLogController : BaseController
    {
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public ISystemLogBLL systemLogBLL { get; set; }
        // GET: SystemLog
        public ActionResult Index()
        {
            ViewBag.PageTitle = "系统日志";
            return View();
        }
    }
}