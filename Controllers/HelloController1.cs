using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Greeting()
        {
            return "chao mung cac ban da den ";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(int id, string name)
        {
            return $"Chao mung {id} - {name} chuc mung";
        }
        public IActionResult Welcome1(int id1, string name)
        {
            ViewBag.Id = id1;
            ViewBag.Name = name;
            return View("Welcome1");
        }
    }
}