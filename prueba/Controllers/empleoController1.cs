using Microsoft.AspNetCore.Mvc;

namespace prueba.Controllers
{
    public class empleoController1 : Controller
    {
        // GET: empleoController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: empleoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
