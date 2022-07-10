using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IPassengerService
    {
        public Task PassengerAddAsync(PassengerToAddDTO passengerToAddDTO);
        public Task<List<PassengerToGetDTO>> GetPassengersAsync();
        public Task DeletePassengerAsync(int passengerId); 
    }
}
