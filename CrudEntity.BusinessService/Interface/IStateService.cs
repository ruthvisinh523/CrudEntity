using CrudEntity.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEntity.BusinessService.Interface
{
   public interface  IStateService
    {
        List<StateViewModel> GetStateDetails();

        StateViewModel GetStateDetails(int id);
    }
}
