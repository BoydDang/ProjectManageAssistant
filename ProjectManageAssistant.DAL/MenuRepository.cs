using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using System;
using System.Linq;

namespace ProjectManageAssistant.DAL
{
    public class MenuRepository : CommonRepository<SystemMenu>, IMenuRepository
    {
        public MenuRepository(DefaultEntities db) : base(db)
        {

        }
    }
}
