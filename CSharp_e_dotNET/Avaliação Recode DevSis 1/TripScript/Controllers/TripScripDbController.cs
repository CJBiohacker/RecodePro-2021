using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TripScript.Controllers
{
    public class TripScriptDbContext : Controller
    {
        private readonly TripScriptDbContext _context;

        public TripScriptDbContext(TripScriptDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}