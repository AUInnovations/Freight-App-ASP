using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;

namespace FreightAppASP.Controllers
{
    public class CarrierRegistrationController : Controller
    {
			public IActionResult Index()
			{
					return View();
			}
	}
}
