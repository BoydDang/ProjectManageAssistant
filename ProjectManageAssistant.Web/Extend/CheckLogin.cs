using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManageAssistant.Web.Extend
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
    public sealed class CheckLogin : Attribute
    {
        public bool IsNeedLogin = false;
        public CheckLogin(bool isNeedLogin)
        {
            IsNeedLogin = isNeedLogin;
        }
    }
}