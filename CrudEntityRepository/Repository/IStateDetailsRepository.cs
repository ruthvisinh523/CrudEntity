using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace CrudEntityRepository.Repository
{
    public interface IStateDetailsRepository
    {
        List<StateDetail> GetStateDetails();

        StateDetail GetStateDetails(int id);

    }
}
