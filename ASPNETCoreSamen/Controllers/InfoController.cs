using ASPNETCoreSamen.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreSamen.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            var vm = new InfoViewModel
            {
                FirstName = "Ken",
                LastName = "Field",
                Age = 26
            };

            return View(vm);
        }
    }
}
