using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.DAL
{
    public class SystemExceptionRepository: CommonRepository<Models.SystemException>, ISystemExceptionRepository
    {
        public SystemExceptionRepository(DefaultEntities db) : base(db)
        {

        }
    }
}
