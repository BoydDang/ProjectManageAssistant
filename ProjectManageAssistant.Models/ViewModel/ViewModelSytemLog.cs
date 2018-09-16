using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.Models.ViewModel
{
    public class ViewModelSytemLog
    {
        public string Id { get; set; }
        public string Operator { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
        public string Type { get; set; }
        public string Module { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
