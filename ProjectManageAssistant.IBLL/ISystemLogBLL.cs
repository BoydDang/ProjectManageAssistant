using ProjectManageAssistant.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.IBLL
{
    public interface ISystemLogBLL
    {
        List<ViewModelSytemLog> GetList(string queryStr);
        ViewModelSytemLog GetById(string id);
        bool Create(ViewModelSytemLog model);
    }
}
