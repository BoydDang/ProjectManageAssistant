using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.Models.ViewModel
{
    public class ViewModelSystemException
    {
        public string Id { get; set; }
        public string HelpLink { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSite { get; set; }
        public string Data { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
