using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Fly
    {
        public int FlyId { get; set; }
        public string FlySeries { get; set; }

        public List<City> City { get; set; }

        public int CityId { get; set; }
        //  public List<DepartureCity> DepartureCity { get; set; }
        // [ForeignKey("DepartureCity")]
        // public int DepartureCityId { get; set; }
        //  public List<ArrivalCity> ArrivalCity { get; set; }
        // [ForeignKey("ArrivalCity")]
        //  public int ArrivalCityId { get; set; } 
        public string DepartureCityName { get; set; }
        public string ArrivalCityName { get; set; }
        public string Airport_1 { get; set; }
        public string Airport_2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy:hh}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }
        public string Terminal { get; set; }
        public int Capacity { get; set; }
        public int NumberOfTicket { get; set; }
        public int Price { get; set; }
        public List<Passenger> Passengers { get; set; }
        public int PassengerId { get; set; }
    }
}
