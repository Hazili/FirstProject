using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirLinesTicketSales.Controllers
{
    public class OffersController : Controller
    {
        [Authorize]
        public IActionResult Offers()
        {
            return View();
        }
    }
}
