using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index (Person ps)
        {
            string strResult = "Xin chao " + ps.PersonID + "-" + ps.FullName;
            ViewBag.Info = strResult;
            return View();
        }
    }
}
