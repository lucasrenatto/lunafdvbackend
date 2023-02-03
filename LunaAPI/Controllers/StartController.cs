using LunaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LunaAPI.Controllers
{
    public class StartController : Controller
    {

        public IActionResult Start()
        {
            return View();
        }

    }
}
