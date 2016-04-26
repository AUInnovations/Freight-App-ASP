using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using FreightAppASP.DataContexts;
using FreightAppASP.Models;
using FreightAppASP.Services;
using Kendo.Mvc.UI;
using FreightAppASP.ViewModels;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

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

        public ActionResult Carriers_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCarriers().ToDataSourceResult(request));
        }
    
        private static IEnumerable<CarrierViewModel> GetCarriers()
        {
            var carr = new CarrierContext();

            return carr.Carriers.ToList().Select(carrier => new CarrierViewModel
            {
                CompanyName = carrier.CompanyName,
                CarrierId = carrier.CarrierId,
                PhysicalCity = carrier.PhysicalCity,
                PhysicalState = carrier.PhysicalState,
                PhysicalZip = carrier.PhysicalZip,
                PrimaryContactName = carrier.PrimaryContactName,
                PhysicalAddress = carrier.PhysicalAddress,
                DotNumber = carrier.DotNumber,
                IsTaxtId = carrier.IsTaxtId,
                DbaName = carrier.DbaName,
                MailingAddress = carrier.MailingAddress,
                MailingCity = carrier.MailingCity,
                MailingState = carrier.MailingState,
                MailingZip = carrier.MailingZip,
                Phone = carrier.Phone,
                Fax = carrier.Fax,
                PrimaryContactPhone = carrier.PrimaryContactPhone,
                PrimaryContactEmail = carrier.PrimaryContactEmail,
                DispatchContactName = carrier.DispatchContactName,
                DispatchContactPhone = carrier.DispatchContactPhone,
                DispatchContactEmail = carrier.DispatchContactEmail,
                AccountingContactName = carrier.AccountingContactName,
                AccountingContactPhone = carrier.AccountingContactPhone,
                AccountingContactEmail = carrier.AccountingContactEmail,
                Rating = carrier.Rating
            });
            }

        // GET: Carriers
        public IActionResult Index()
        {
          //  var model = carrierService.GetCarriers();
           
            return View();
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
