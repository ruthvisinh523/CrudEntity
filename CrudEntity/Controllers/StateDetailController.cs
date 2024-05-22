using CrudEntityRepository.Concreate;
using CrudEntityRepository.Repository;
using Microsoft.AspNetCore.Mvc;


    namespace CrudEntity.Controllers
{
    public class StateDetailController : Controller
    {
        private readonly IStateDetailsRepository stateDetailsRepository;

        public StateDetailController()
        {
            stateDetailsRepository = new StateDetailsRepository();
        }
        public IActionResult StateDetail()
        {
            return View(stateDetailsRepository.GetStateDetails());
        }

        public IActionResult Index()
        {
            return View(stateDetailsRepository.GetStateDetails());
        }
    }
}
