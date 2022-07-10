using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
   public class PilotGalery
    {
        [Key]
        public int Id { get; set; }
       [MaxLength(50)]
        public string FullName { get; set; }
        public string ImageURL { get; set; }
    }
}
