using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using ProjectManageAssistant.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;
using Unity.Attributes;

namespace ProjectManageAssistant.BLL
{
    public class MenuBLL: IMenuBLL
    {
        DefaultEntities db = new DefaultEntities();
        [Dependency]
        public IMenuRepository Rep { get; set; }
        public IEnumerable<ViewModelMenuInfo> GetList(string queryStr)
        {

            IQueryable<SystemMenu> queryData = Rep.GetList();


            return CreateModelList(ref queryData);
        }

        private IEnumerable<ViewModelMenuInfo> CreateModelList(ref IQueryable<SystemMenu> queryData)
        {
            List<ViewModelMenuInfo> modelList = (from r in queryData
                                                 where r.State == true && r.ParentMenuID == 0
                                                 select new ViewModelMenuInfo
                                                 {
                                                     CreatePerson = r.CreatePerson,
                                                     CreateTime = r.CreateTime,
                                                     EnglishName = r.EnglishName,
                                                     Iconic = r.Iconic,
                                                     ID = r.ID,
                                                     MenuName = r.MenuName,
                                                     ParentMenuID = r.ParentMenuID,
                                                     Remark = r.Remark,
                                                     Sort = r.Sort,
                                                     State = r.State,
                                                     Url = r.Url,
                                                     ActionName = r.ActionName,
                                                     ControlName = r.ControlName
                                                 }).ToList();
            for (int i = 0; i < modelList.Count; i++)
            {
                int parentID = modelList[i].ID;
                modelList[i].SubMenus.AddRange(from r in queryData
                                                        where r.State == true && r.ParentMenuID == parentID
                                                        select new ViewModelMenuInfo
                                                        {
                                                            CreatePerson = r.CreatePerson,
                                                            CreateTime = r.CreateTime,
                                                            EnglishName = r.EnglishName,
                                                            Iconic = r.Iconic,
                                                            ID = r.ID,
                                                            MenuName = r.MenuName,
                                                            ParentMenuID = r.ParentMenuID,
                                                            Remark = r.Remark,
                                                            Sort = r.Sort,
                                                            State = r.State,
                                                            Url = r.Url,
                                                            ActionName = r.ActionName,
                                                            ControlName = r.ControlName
                                                        });
            }
            return modelList;
        }
    }
}
