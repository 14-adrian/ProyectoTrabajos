using Microsoft.AspNetCore.Mvc;
using prueba.Models;

namespace prueba.Controllers
{
    public class PrincipalPageController : Controller
    {
        private readonly trabajosDbContext _context;

        public PrincipalPageController(trabajosDbContext context)
        {
            _context = context;
        }


        // GET: PrincipalPage
        public IActionResult Index()
        {

            var count = (from x in _context.empresa select x.empresaID).Count();

            var count2 = (from x in _context.ofertas select x.ofertaID).Count();

            var empresa = (from m in _context.ofertas
                           select m).ToList()
                           .OrderByDescending(m => m.ofertaID).Take(3);

            var testimonios = (from n in _context.testimonios
                               select n).ToList();

            ViewData["contar"] = count;
            ViewData["contarPlazas"] = count2;
            ViewData["testimonios"] = testimonios;
            ViewData["empresa"] = empresa;
            return View();


        }


    }
}