using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IFlyService
    {
        public Task AddAsync(FlyToAddOrUpdateDTO flyToAddOrUpdateDTO);
        public Task<List<FlyToGetDTO>> GetFliesAsync();
        public Task DeleteFlyAsync(int flyId);

       // public Task<FlyToAddOrUpdateDTO> GetDepartureAndArrivalCity();

        //public Task<FlyToAddOrUpdateDTO> InnerMethod();
        
    }
}
