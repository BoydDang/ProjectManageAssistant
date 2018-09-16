using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ProjectManageAssistant.DAL
{
    public class UserRepository : CommonRepository<UserInfo>,IUserRepository
    {
        DefaultEntities db;
        public UserRepository(DefaultEntities db) : base(db)
        {
            this.db = db;
        }

        public bool IsExist(string name, string password)
        {
            if (db.UserInfo.FirstOrDefault(p => p.UserName == name && p.UserPassword == password) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
