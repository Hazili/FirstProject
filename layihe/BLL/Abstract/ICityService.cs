using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface ICityService
    {
        public Task<List<CityToGetDTO>> GetCityAsync();
        public Task CityAddAsync(CityToAddOrUpdateDTO cityToAddOrUpdateDTO);
    }
}
