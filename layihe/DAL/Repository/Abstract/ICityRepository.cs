using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
    public interface ICityRepository
    {
        public Task<List<City>> GetCityAsync();
        public Task CityAddAsync(City city);
    }
}
