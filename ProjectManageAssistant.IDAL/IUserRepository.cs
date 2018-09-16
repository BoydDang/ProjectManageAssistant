using ProjectManageAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.IDAL
{
    public interface IUserRepository : ICommonRepository<UserInfo>
    {
        bool IsExist(string name, string password);
    }
}
