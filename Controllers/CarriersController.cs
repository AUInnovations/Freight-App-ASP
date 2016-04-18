using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc;
using FreightAppASP.DataContexts;
using FreightAppASP.Models;
using FreightAppASP.Services;
using Microsoft.AspNet.Http;

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

        public void Seed()
        {
            SeedData.Initialize(_context);            
        }

        // GET: Carriers
        public IActionResult Index()
        {
            var model = carrierService.Read();

            return View(model);
        }

        // Import
        public IActionResult Import()
        {
            ViewData["Message"] = "Import Carriers.";

            return View();
        }

        [HttpPost]
        public ActionResult Submit(IEnumerable<IFormFile> files)
        {
            if (files != null)
            {
                carrierService.ImportCarriers(files);
            }

            return RedirectToAction("Index");
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
