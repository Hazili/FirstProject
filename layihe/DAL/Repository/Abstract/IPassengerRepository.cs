using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
    public interface IPassengerRepository
    {
        public Task PassengerAddAsync(Passenger passenger);
        public Task<List<Passenger>> GetPassengersAsync();
        public Task DeletePassengerAsync(int passengerId);
    }
}
