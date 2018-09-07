using ProjectManageAssistant.BLL;
using ProjectManageAssistant.DAL;
using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.IDAL;
using Unity;

namespace ZhuoHengProjectManage.Core
{
    public class DependencyRegisterType
    {
        public static void Container_Sys(ref UnityContainer container)
        {
            container.RegisterType<IUserBLL, UserBLL>();//样例
            container.RegisterType<IUserRepository, UserRepository>();
        }
    }
}
