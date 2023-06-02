using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba.Models;

namespace prueba.Controllers
{
    public class empleoController1 : Controller
    {
        private readonly trabajosDbContext _context;

        public empleoController1(trabajosDbContext context)
        {
            _context = context;
        }

        // GET: empleoController1
        public async Task<IActionResult> Index()
        {

            var LEmpleo = (from m in _context.ofertas
                           select m).ToList()
                           .OrderByDescending(m => m.ofertaID);
            ViewData["ofertas"] = LEmpleo;
            return _context.ofertas != null ?
                    View(await _context.ofertas.ToListAsync()) :
                    Problem("Entity set 'trabajosDbContext.empresa'  is null.");
        }

        // GET: empleoController1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ofertas == null)
            {
                return NotFound();
            }

            var oferta = await _context.ofertas
                .FirstOrDefaultAsync(m => m.ofertaID == id);
            var empresa = (from m in _context.empresa
                           where m.empresaID == oferta.empresaID
                           select m
                           ).ToList();
            ViewData["empresa"] = empresa;
            if (oferta == null)
            {
                return NotFound();
            }

            return View(oferta);
        }

        // GET: empleoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: empleoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: empleoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: empleoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: empleoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: empleoController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}
