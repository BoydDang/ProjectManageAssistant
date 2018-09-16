using ProjectManageAssistant.Web.Extend;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class HomeController : BaseController
    {
        // GET: Index
        public ActionResult Index()
        {
            ViewBag.PageTitle = "用户信息";
            return View();
        }
    }
}