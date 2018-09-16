using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using ProjectManageAssistant.Common;
using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.Models.ViewModel;
using ProjectManageAssistant.Web.Core;
using ProjectManageAssistant.Web.Extend;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Unity.Attributes;

namespace ProjectManageAssistant.Web.Controllers
{
    [CheckLogin(true)]
    public class UserController : BaseController
    {   
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public IUserBLL userBLL { get; set; }
        ValidationErrors errors = new ValidationErrors();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReadUser([DataSourceRequest]DataSourceRequest request)
        {
            return Json(userBLL.GetList("").AsQueryable().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UpdateUser([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ViewModelUserInfo> userInfo)
        {
            if (userInfo != null && ModelState.IsValid)
            {
                foreach (var entity in userInfo)
                {
                    userBLL.Edit(entity);
                }
            }
            return Json(userInfo.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DestroyUser([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ViewModelUserInfo> userInfo)
        {
            if (userInfo.Any())
            {
                foreach (var entity in userInfo)
                {
                    userBLL.Delete(entity.UserID.ToString());
                }
            }
            return Json(userInfo.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateUser([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ViewModelUserInfo> userInfo)
        {
            var results = new List<ViewModelUserInfo>();
            if (userInfo != null && ModelState.IsValid)
            {
                foreach (var entity in userInfo)
                {
                    if (userBLL.Create(ref errors, entity))
                    {
                        LogHandler.WriteServiceLog(HttpContext.User.Identity.Name, entity.UserID + "-" + entity.UserName, "成功", "新增", "UserInfo");
                    }
                    else
                    {
                        string ErrorCol = errors.Error;
                        LogHandler.WriteServiceLog(HttpContext.User.Identity.Name, entity.UserID + "-" + entity.UserName+"-"+ ErrorCol, "失败", "新增", "UserInfo");
                    }
                    results.Add(entity);
                }
            }
            return Json(results.ToDataSourceResult(request, ModelState));
        }
    }
}