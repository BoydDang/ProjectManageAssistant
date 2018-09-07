using ProjectManageAssistant.Web.Extend;
using System.Linq;
using System.Web.Mvc;

namespace ProjectManageAssistant.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)


        {
            base.OnActionExecuting(filterContext);

            bool result = false;

            var controllerAttrs = filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(typeof(CheckLogin), false);
            if (controllerAttrs.Count() > 0)
            {
                var conAttr = controllerAttrs[0] as CheckLogin;
                if (conAttr != null)
                {
                    if (conAttr.IsNeedLogin)
                        result = true;
                    else
                        result = false;
                }
            }

            var actionAttrs = filterContext.ActionDescriptor.GetCustomAttributes(typeof(CheckLogin), false);
            if (actionAttrs.Count() > 0)
            {
                var actAttr = actionAttrs[0] as CheckLogin;
                if (actAttr != null)
                {
                    if (actAttr.IsNeedLogin)
                        result = true;
                    else
                        result = false;
                }
            }

            if (!IsLogin() && result)
                filterContext.Result = Redirect("/Account/Login");
        }

        protected bool IsLogin()
        {
            if (Session["UserInfo"] != null)
                return true;
            return false;
        }
    }
}