using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
   public class UserToAddOrUpdateDTO
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string EmailAdress { get; set; }
    }
}
