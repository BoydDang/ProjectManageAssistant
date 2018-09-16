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
    public class SystemLogBLL : ISystemLogBLL
    {
        DefaultEntities db = new DefaultEntities();
        [Dependency]
        public ISystemLogRepository Rep { get; set; }

        public List<ViewModelSytemLog> GetList(string queryStr)
        {
            IQueryable<SystemLog> list = Rep.GetList();
            return CreateModelList(ref list);
        }

        private List<ViewModelSytemLog> CreateModelList(ref IQueryable<SystemLog> queryData)
        {
            List<ViewModelSytemLog> modelList = (from r in queryData
                                                 select new ViewModelSytemLog
                                                 {
                                                     CreateTime = r.CreateTime,
                                                     Id = r.Id,
                                                     Message = r.Message,
                                                     Module = r.Module,
                                                     Operator = r.Operator,
                                                     Result = r.Result,
                                                     Type = r.Type
                                                 }).ToList();

            return modelList;
        }

        public ViewModelSytemLog GetById(string id)
        {
            var entity = Rep.GetById(db, id);
            if (entity != null)
            {
                ViewModelSytemLog model = new ViewModelSytemLog()
                {
                    CreateTime = entity.CreateTime,
                    Id = entity.Id,
                    Message = entity.Message,
                    Module = entity.Module,
                    Operator = entity.Operator,
                    Result = entity.Result,
                    Type = entity.Type
                };
                return model;
            }
            else
            {
                return new ViewModelSytemLog();
            }

        }
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Create(ViewModelSytemLog model)
        {
            try
            {
                SystemLog entity = Rep.GetById(db, model.Id);
                if (entity != null)
                {
                    return false;
                }
                entity = new SystemLog();
                entity.Id = model.Id;
                entity.Message = model.Message;
                entity.Module = model.Module;
                entity.Operator = model.Operator;
                entity.Result = model.Result;
                entity.Type = model.Type;
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
