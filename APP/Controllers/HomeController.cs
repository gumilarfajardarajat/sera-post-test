using APP.DbContexts;
using APP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP.Controllers
{
    public class HomeController : Controller
    {

        private IPersonalService _personalService;

        public HomeController(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        public IActionResult Index()
        {
            var personalDataSimActiveResponse = _personalService.GetPersonalDataSimActiveResponse();
            var personalDataActiveCountResponse = _personalService.GetPersonalDataActiveCountResponse();
            ViewData["personalDataSimActiveResponse"] = personalDataSimActiveResponse;
            ViewData["personalDataActiveCountResponse"] = personalDataActiveCountResponse;
            return View();
        }

    }
}
