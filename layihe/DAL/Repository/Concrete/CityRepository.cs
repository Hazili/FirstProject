using DAL.DataContext;
using DAL.Repository.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _appDbContext;
        public CityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CityAddAsync(City city)
        {
           await _appDbContext.Cities.AddAsync(city);
        }


        public async Task<List<City>> GetCityAsync()
        {
            List<City> cities = _appDbContext.Cities.ToList();
            return cities;
        }
    }
}
