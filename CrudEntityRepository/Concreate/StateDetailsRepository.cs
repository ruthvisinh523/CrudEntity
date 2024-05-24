using CrudEntityRepository.Repository;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEntityRepository.Concreate
{
    public class StateDetailsRepository : IStateDetailsRepository
    {
        private readonly CrudContext context;
        public StateDetailsRepository() { 
            context = new CrudContext();
        }

        public StateDetail GetStateDetails(int id)
        {
            return context.StateDetails.Find(id);
        }

        public List<StateDetail> GetStateDetails()
        {
            return context.StateDetails.ToList();
        }
    }
}
