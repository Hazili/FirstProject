
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class AddPilotImage
    {
        public int PilotId { get; set; }
        public string PilotFullName { get; set; }
        public IFormFile ImageURL { get; set; }
    }
}
