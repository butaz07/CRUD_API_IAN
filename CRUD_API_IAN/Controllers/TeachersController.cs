using Microsoft.AspNetCore.Mvc;

namespace CRUD_API_IAN.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
