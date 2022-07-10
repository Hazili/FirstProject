using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string PassengerSurname { get; set; }
        [MaxLength(9)]
        public string PassengerPassportNo { get; set; }
        public Fly Fly { get; set; }

    }
}
