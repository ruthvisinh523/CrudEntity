using CrudEntity.BusinessEntity;
using CrudEntity.BusinessService.Interface;
using CrudEntityRepository.Concreate;
using CrudEntityRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comman;
using static CrudEntity.BusinessService.Concret.StateService;

namespace CrudEntity.BusinessService.Concret
{

    public class StateService : IStateService
    {
        private readonly IStateDetailsRepository _repo;


        public StateService()
        {

            _repo = new StateDetailsRepository();
        }

        public List<StateViewModel> GetStateDetails()
        {
            var d = _repo.GetStateDetails();
            return d.ToViewModel();
        }

        public StateViewModel GetStateDetails(int id)
        {
            var d = _repo.GetStateDetails(id);
            return d.ToViewModel();
        }
    }
}
       