//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManageAssistant.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemMenu
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
    }
}
