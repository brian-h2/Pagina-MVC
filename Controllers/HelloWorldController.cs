using Microsoft.AspNetCore.Mvc;
using Pagina_MVC.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace Pagina_MVC.Controllers
{
	public class HelloWorldController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 2)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
