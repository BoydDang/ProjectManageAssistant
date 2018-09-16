using ProjectManageAssistant.Models.ViewModel;
using System.Collections.Generic;

namespace ProjectManageAssistant.IBLL
{
    public interface IMenuBLL
    {
        IEnumerable<ViewModelMenuInfo> GetList(string queryStr);
    }
}
