using Microsoft.AspNetCore.Mvc;
using Filmes.Data;

namespace Filmes.Controllers
{
    public class FilmeController : Controller
    {
        private readonly FilmeContext _context;

        public FilmeController(FilmeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}