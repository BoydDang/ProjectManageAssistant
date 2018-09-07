using ProjectManageAssistant.IDAL;
using ProjectManageAssistant.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ProjectManageAssistant.DAL
{
    public class UserRepository: IUserRepository, IDisposable
    {
        /// <summary>
    /// 获取列表
    ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        public IQueryable<UserInfo> GetList(DefaultEntities db)
        {
            IQueryable<UserInfo>
                list = db.UserInfo.AsQueryable();
            return list;
        }
        /// <summary>
            /// 创建一个实体
            ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">实体</param>
        public int Create(UserInfo entity)
        {
            using (DefaultEntities db = new DefaultEntities())
            {
                db.Set<UserInfo>().Add(entity);
                return db.SaveChanges();
            }
        }
        /// <summary>
            /// 删除一个实体
            ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">主键ID</param>
        public int Delete(string id)
        {
            using (DefaultEntities db = new DefaultEntities())
            {
                UserInfo entity = db.UserInfo.SingleOrDefault(a => a.UserID.ToString() == id);
                db.Set<UserInfo>().Remove(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
            /// 修改一个实体
            ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">实体</param>
        public int Edit(UserInfo entity)
        {
            using (DefaultEntities db = new DefaultEntities())
            {
                db.Set<UserInfo>().Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        /// <summary>
            /// 获得一个实体
            ///</summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public UserInfo GetById(string id)
        {
            using (DefaultEntities db = new DefaultEntities())
            {
                return db.UserInfo.SingleOrDefault(a => a.UserID.ToString() == id);
            }
        }
        /// <summary>
        /// 判断一个实体是否存在
        ///</summary>
        /// <param name="id">id</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(string id)
        {
            UserInfo entity = GetById(id);
            if (entity != null)
                return true;
            return false;
        }

        public bool IsExist(string name, string password)
        {
            using (DefaultEntities db = new DefaultEntities())
            {
                if (db.UserInfo.FirstOrDefault(p => p.UserName == name && p.UserPassword == password) != null)
                    return true;
                else
                    return false;
            }
        }

        public void Dispose()
        {

        }
    }
}
