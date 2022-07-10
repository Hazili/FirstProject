using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
    public class PassengerToAddDTO
    {
        public int? PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string PassengerSurname { get; set; }
        public string PassengerPassportNo { get; set; }
        public FlyToAddOrUpdateDTO FlyToAddOrUpdateDTO { get; set; }
    }
}
