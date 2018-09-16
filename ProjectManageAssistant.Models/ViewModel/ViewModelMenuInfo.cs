using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.Models.ViewModel
{
    public class ViewModelMenuInfo
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public string EnglishName { get; set; }
        public Nullable<int> ParentMenuID { get; set; }
        public string Url { get; set; }
        public string Iconic { get; set; }
        public Nullable<int> Sort { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> State { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string ControlName { get; set; }
        public string ActionName { get; set; }

        public List<ViewModelMenuInfo> SubMenus { get; set; }

        public ViewModelMenuInfo()
        {
            SubMenus = new List<ViewModelMenuInfo>();
        }
    }
}
