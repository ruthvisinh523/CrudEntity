using CrudEntityRepository.Concreate;
using CrudEntityRepository.Repository;
using Microsoft.AspNetCore.Mvc;
using CrudEntity.BusinessService.Interface;
using CrudEntity.BusinessService.Concret;


namespace CrudEntity.Controllers
{
    public class StateDetailController : Controller
    {
        private readonly IStateService stateService;
        public StateDetailController()
        {
            stateService = new StateService();
        }
        public IActionResult StateDetail()
        {
            return View(stateService.GetStateDetails());
        }

        public IActionResult Index()
        {
            return View(stateService.GetStateDetails());
        }
    }
}
