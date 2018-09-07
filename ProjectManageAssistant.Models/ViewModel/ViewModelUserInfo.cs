using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.Models.ViewModel
{
    public class ViewModelUserInfo
    {
        [Display(Name = "ID")]
        public int UserID { get; set; }


        [Display(Name = "名称")]
        public string UserName { get; set; }


        [Display(Name = "密码")]
        public string UserPassword { get; set; }

        [Display(Name = "记住我")]
        public bool RememberMe { get; set; }
    }
}
