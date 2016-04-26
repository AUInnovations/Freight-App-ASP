using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using FreightAppASP.DataContexts;
using FreightAppASP.Models;
using FreightAppASP.Services;
using Kendo.Mvc.UI;
using System.Collections.Generic;
using FreightAppASP.ViewModels;
using Kendo.Mvc.Extensions;

namespace FreightAppASP.Controllers
{
    public class LanesController : Controller
    {
        private CarrierContext _context;
        private LaneService laneService;

        public LanesController(CarrierContext context)
        {
            _context = context;
        laneService = new LaneService(_context); 
        }

        public ActionResult Lanes_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetLanes().ToDataSourceResult(request));
        }

        public ActionResult Binding_Lanes(int carrierId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetLanes()
                .Where(order => order.CarrierId == carrierId)
                .ToDataSourceResult(request));
        }

        private static IEnumerable<LaneViewModel> GetLanes()
        {
            var lanes = new CarrierContext();

            return lanes.Lanes.ToList().Select(lane => new LaneViewModel
            {
                LaneId = lane.LaneId,
                CarrierId = lane.CarrierId,
                OriginCity = lane.OriginCity,
                OriginState = lane.OriginState,
                OriginZip = lane.OriginZip,
                DestinationCity = lane.DestinationCity,
                DestinationState = lane.DestinationState,
                DestinationZip = lane.DestinationZip,
                Radius = lane.Radius
            });
        }

        // GET: Lanes
        public IActionResult Index()
        {
        
            return View();
        }

        // GET: Lanes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Lanes lanes = _context.Lanes.Single(m => m.LaneId == id);
            if (lanes == null)
            {
                return HttpNotFound();
            }

            return View(lanes);
        }

        // GET: Lanes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lanes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Lanes lanes)
        {
            if (ModelState.IsValid)
            {
                _context.Lanes.Add(lanes);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lanes);
        }

        // GET: Lanes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Lanes lanes = _context.Lanes.Single(m => m.LaneId == id);
            if (lanes == null)
            {
                return HttpNotFound();
            }
            return View(lanes);
        }

        // POST: Lanes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Lanes lanes)
        {
            if (ModelState.IsValid)
            {
                _context.Update(lanes);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lanes);
        }

        // GET: Lanes/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Lanes lanes = _context.Lanes.Single(m => m.LaneId == id);
            if (lanes == null)
            {
                return HttpNotFound();
            }

            return View(lanes);
        }

        // POST: Lanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Lanes lanes = _context.Lanes.Single(m => m.LaneId == id);
            _context.Lanes.Remove(lanes);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
