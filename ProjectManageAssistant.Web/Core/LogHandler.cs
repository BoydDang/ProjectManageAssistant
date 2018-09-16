using ProjectManageAssistant.Common;
using ProjectManageAssistant.IBLL;
using ProjectManageAssistant.Models.ViewModel;
using Unity.Attributes;

namespace ProjectManageAssistant.Web.Core
{
    public class LogHandler
    {
        [Dependency]
        public static ISystemLogBLL logBLL { get; set; }
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="oper">操作人</param>
        /// <param name="mes">操作信息</param>
        /// <param name="result">结果</param>
        /// <param name="type">类型</param>
        /// <param name="module">操作模块</param>
        public static void WriteServiceLog(string oper, string mes, string result, string type, string module)
        {
            ViewModelSytemLog model = new ViewModelSytemLog();
            model.Id = Helper.NewId;
            model.Operator = oper;
            model.Message = mes;
            model.Result = result;
            model.Type = type;
            model.Module = module;
            model.CreateTime = Helper.NowTime;
            logBLL.Create(model);
        }
    }
}