using ProjectManageAssistant.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageAssistant.IBLL
{
    public interface ISystemExceptionBLL
    {
        List<ViewModelSystemException> GetList(string queryStr);
        ViewModelSystemException GetById(string id);
        bool Create(ViewModelSystemException model);
    }
}
