using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
