using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs
{
    public class FlyToGetDTO
    {
        public int FlyId { get; set; }
        public string FlySeries { get; set; }
        public List<CityToGetDTO> City { get; set; }
        public string DepartureCityName { get; set; }
        public string ArrivalCityName { get; set; }
        public List<DepartureCityDTO> DepartureCity { get; set; }
        public int DepartureCityId { get; set; }
        public List<ArrivalCityDTO> ArrivalCity { get; set; }
        public int ArrivalCityId { get; set; }
        //  public string DepartureCity { get; set; } 
        //  public string ArrivalCity { get; set; }
        public string Airport_1 { get; set; }
        public string Airport_2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy:hh}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }
        public string Terminal { get; set; }
        public int Capacity { get; set; }
        public int NumberOfTicket { get; set; }
        public int Price { get; set; }
    }
}
