using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.Models.ViewModel;
using ProjectManageAssistant.Web.Extend;
using Unity.Attributes;

namespace ProjectManageAssistant.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public IUserBLL M_BLL { get; set; }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ExtendedValidateAntiForgeryToken]
        public ActionResult Login(ViewModelUserInfo user)
        {
            if (M_BLL.IsExist(user.UserName,user.UserPassword))
            {
                FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                if (Session["UserInfo"] == null)
                {
                    Session["UserInfo"] = user;
                }

                return Redirect("/Home/Index");
            }
            else
            {
                return View("Login", user);
            }
        }
    }
}