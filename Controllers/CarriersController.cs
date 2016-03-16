using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using FreightAppASP.DataContexts;
using FreightAppASP.Models;
using FreightAppASP.Services;

namespace FreightAppASP.Controllers
{
    public class CarriersController : Controller
    {
        private CarrierContext _context;
        private CarrierService carrierService;

        public CarriersController(CarrierContext context)
        {
            _context = context;
            carrierService = new CarrierService(_context);    
        }

        // GET: Carriers
        public IActionResult Index()
        {
            var model = carrierService.Read();

            return View(model);
        }

        // GET: Carriers/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Carrier carrier = _context.Carriers.Single(m => m.CarrierId == id);
            if (carrier == null)
            {
                return HttpNotFound();
            }

            return View(carrier);
        }

        // GET: Carriers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carriers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Carrier carrier)
        {
            if (ModelState.IsValid)
            {
                _context.Carriers.Add(carrier);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carrier);
        }

        // GET: Carriers/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Carrier carrier = _context.Carriers.Single(m => m.CarrierId == id);
            if (carrier == null)
            {
                return HttpNotFound();
            }
            return View(carrier);
        }

        // POST: Carriers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Carrier carrier)
        {
            if (ModelState.IsValid)
            {
                _context.Update(carrier);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carrier);
        }

        // GET: Carriers/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Carrier carrier = _context.Carriers.Single(m => m.CarrierId == id);
            if (carrier == null)
            {
                return HttpNotFound();
            }

            return View(carrier);
        }

        // POST: Carriers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Carrier carrier = _context.Carriers.Single(m => m.CarrierId == id);
            _context.Carriers.Remove(carrier);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
