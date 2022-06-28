using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class MoviesTestController : Controller
    {
        // 
        // GET: /Movies/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /Movies/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}