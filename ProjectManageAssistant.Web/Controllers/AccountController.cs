using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.Models.ViewModel;
using ProjectManageAssistant.Web.Extend;
using Unity.Attributes;

namespace ProjectManageAssistant.Web.Controllers
{
    public class AccountController : BaseController
    {
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public IUserBLL M_BLL { get; set; }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ExtendedValidateAntiForgeryToken]
        public ActionResult Login(ViewModelUserInfo user)
        {
            if (M_BLL.IsExist(user.UserName,user.UserPassword))
            {
                if (Session["UserInfo"] == null)
                    Session["UserInfo"] = user;
                return Redirect("/Home/Index");
            }
            else
            {
                return View("Login", user);
            }
        }
    }
}