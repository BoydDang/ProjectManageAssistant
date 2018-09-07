using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using ProjectManageAssistant.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Attributes;

namespace ProjectManageAssistant.BLL
{
    public class UserBLL : IUserBLL
    {
        DefaultEntities db = new DefaultEntities();
        [Dependency]
        public IUserRepository Rep { get; set; }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pager">JQgrid分页</param>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>列表</returns>
        public List<ViewModelUserInfo> GetList(string queryStr)
        {

            IQueryable<UserInfo> queryData = Rep.GetList(db);


            return CreateModelList(ref queryData);
        }

        private List<ViewModelUserInfo> CreateModelList(ref IQueryable<UserInfo> queryData)
        {
            List<ViewModelUserInfo> modelList = (from r in queryData
                                                 select new ViewModelUserInfo
                                                 {
                                                     UserID = r.UserID,
                                                     RememberMe = r.RememberMe,
                                                     UserName = r.UserName,
                                                     UserPassword = r.UserPassword
                                                 }).ToList();

            return modelList;
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Create(ViewModelUserInfo model)
        {
            try
            {
                UserInfo entity = Rep.GetById(model.UserID.ToString());
                if (entity != null)
                {
                    return false;
                }
                entity = new UserInfo();
                entity.UserID = model.UserID;
                entity.UserName = model.UserName;
                entity.UserPassword = model.UserPassword;
                entity.RememberMe = model.RememberMe;

                if (Rep.Create(entity) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHander.WriteException(ex);
                return false;
            }
        }
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="id">id</param>
        /// <returns>是否成功</returns>
        public bool Delete(string id)
        {
            try
            {
                if (Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Edit(ViewModelUserInfo model)
        {
            try
            {
                UserInfo entity = Rep.GetById(model.UserID.ToString());
                if (entity == null)
                {
                    return false;
                }
                entity.UserID = model.UserID;
                entity.UserName = model.UserName;
                entity.UserPassword = model.UserPassword;
                entity.RememberMe = model.RememberMe;


                if (Rep.Edit(entity) == 1)
                {
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch (Exception ex)
            {

                //ExceptionHander.WriteException(ex);
                return false;
            }
        }
        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否存在</returns>
        public bool IsExists(string id)
        {
            if (db.UserInfo.SingleOrDefault(a => a.UserID.ToString() == id) != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据ID获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public ViewModelUserInfo GetById(string id)
        {
            if (IsExist(id))
            {
                UserInfo entity = Rep.GetById(id);
                ViewModelUserInfo model = new ViewModelUserInfo
                {
                    UserID = entity.UserID,
                    UserName = entity.UserName,
                    UserPassword = entity.UserPassword,
                    RememberMe = entity.RememberMe
                };

                return model;
            }
            else
            {
                return new ViewModelUserInfo();
            }
        }

        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(string id)
        {
            return Rep.IsExist(id);
        }

        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsExist(string name, string password)
        {
            return Rep.IsExist(name, password);
        }
    }
}
