using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.DAL
{
    public class SystemLogRepository : CommonRepository<SystemLog>, ISystemLogRepository
    {
        public SystemLogRepository(DefaultEntities db) : base(db)
        {

        }
    }
}
