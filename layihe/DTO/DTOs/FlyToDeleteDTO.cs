using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
   public class FlyToDeleteDTO
    {
        public int FlyId { get; set; }
        public string FlySeries { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity{ get; set; }
        public string Airport_1 { get; set; }
        public string Airport_2 { get; set; }
        public DateTime DateTime { get; set; }
        public string Terminal { get; set; }
        public int Capacity { get; set; }
        public int NumberOfTicket { get; set; }
        public int Price { get; set; }
        public List<PassengerToGetDTO> Passengers { get; set; }
    }
}
