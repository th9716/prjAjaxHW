using Microsoft.AspNetCore.Mvc;
using prjAjaxHW.Models;
using System.Text;
using System.Xml.Linq;

namespace prjAjaxHW.Controllers
{
    public class APIController : Controller
    {
        public IActionResult index(string name)
        {
            DemoContext _context = new DemoContext();

            return Content($"{name}", "text/plain", Encoding.UTF8);
        }
    }
}
