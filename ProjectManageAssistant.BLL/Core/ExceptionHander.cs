using ProjectManageAssistant.IBLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Unity.Attributes;
using ProjectManageAssistant.Models.ViewModel;
using ProjectManageAssistant.Common;

namespace ProjectManageAssistant.BLL.Core
{
    public class ExceptionHander
    {
        [Dependency]
        public static ISystemExceptionBLL exceptionBLL { get; set; }
        /// <summary>
        /// 加入异常日志
        /// </summary>
        /// <param name="ex">异常</param>
        public static void WriteException(Exception ex)
        {

            try
            {
                ViewModelSystemException model = new ViewModelSystemException() {
                    Id = Helper.NewId,
                    HelpLink = ex.HelpLink,
                    Message = ex.Message,
                    Source = ex.Source,
                    StackTrace = ex.StackTrace,
                    TargetSite = ex.TargetSite.ToString(),
                    Data = ex.Data.ToString(),
                    CreateTime = Helper.NowTime
                };
                exceptionBLL.Create(model);
            }
            catch (Exception ep)
            {
                try
                {
                    //异常失败写入txt
                    string path = @"~/exceptionLog.txt";
                    string txtPath = HttpContext.Current.Server.MapPath(path);//获取绝对路径
                    using (StreamWriter sw = new StreamWriter(txtPath, true, Encoding.Default))
                    {
                        sw.WriteLine((ex.Message + "|" + ex.StackTrace + "|" + ep.Message + "|" + DateTime.Now.ToString()).ToString());
                        sw.Dispose();
                        sw.Close();
                    }
                    return;
                }
                catch { return; }
            }



        }
    }
}