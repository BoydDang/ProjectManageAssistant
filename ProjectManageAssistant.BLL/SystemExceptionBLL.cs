using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using ProjectManageAssistant.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace ProjectManageAssistant.BLL
{
    public class SystemExceptionBLL: ISystemExceptionBLL
    {
        DefaultEntities db = new DefaultEntities();
        [Dependency]
        public ISystemExceptionRepository Rep { get; set; }


        public List<ViewModelSystemException> GetList(string queryStr)
        {
            IQueryable<Models.SystemException> list = Rep.GetList();
            return CreateModelList(ref list);
        }
        private List<ViewModelSystemException> CreateModelList(ref IQueryable<Models.SystemException> queryData)
        {
            List<ViewModelSystemException> modelList = (from r in queryData
                                                 select new ViewModelSystemException
                                                 {
                                                     CreateTime = r.CreateTime,
                                                     Id = r.Id,
                                                     Message = r.Message,
                                                     Data = r.Data,
                                                     HelpLink = r.HelpLink,
                                                     Source = r.Source,
                                                     StackTrace = r.StackTrace,
                                                     TargetSite = r.TargetSite
                                                 }).ToList();

            return modelList;
        }

        public ViewModelSystemException GetById(string id)
        {
            var entity = Rep.GetById(db, id);
            if (entity != null)
            {
                ViewModelSystemException model = new ViewModelSystemException()
                {
                    CreateTime = entity.CreateTime,
                    Id = entity.Id,
                    Message = entity.Message,
                    Data = entity.Data,
                    HelpLink = entity.HelpLink,
                    Source = entity.Source,
                    StackTrace = entity.StackTrace,
                    TargetSite = entity.TargetSite
                };
                return model;
            }
            else
            {
                return new ViewModelSystemException();
            }
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Create(ViewModelSystemException model)
        {
            try
            {
                Models.SystemException entity = Rep.GetById(db, model.Id);
                if (entity != null)
                {
                    return false;
                }
                entity = new Models.SystemException();
                entity.Id = model.Id;
                entity.Message = model.Message;
                entity.Data = model.Data;
                entity.HelpLink = model.HelpLink;
                entity.Source = model.Source;
                entity.StackTrace = model.StackTrace;
                entity.TargetSite = model.TargetSite;
                entity.CreateTime = model.CreateTime;

                if (Rep.Create(entity))
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
    }
}
