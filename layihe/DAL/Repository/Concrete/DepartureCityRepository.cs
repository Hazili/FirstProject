using DAL.DataContext;
using DAL.Repository.Abstract;
using DTO.DTOs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
   public class DepartureCityRepository : IDepartureCityRepository
    {
        private readonly AppDbContext _appDbContext;
        public DepartureCityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
         
        public async Task<List<DepartureCity>> GetDepartureCitiesAsync() 
        {
           List<DepartureCity> departureCity =  _appDbContext.DepartureCities.ToList();
            return departureCity;
        }
    }
}
