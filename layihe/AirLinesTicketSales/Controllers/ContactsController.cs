using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirLinesTicketSales.Controllers
{
    public class ContactsController : Controller
    {
        [Authorize]
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
