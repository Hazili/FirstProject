using DAL.DataContext;
using DAL.Repository.Abstract;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly AppDbContext _appDbContext;
        public PassengerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task DeletePassengerAsync(int passengerId)
        {
           Passenger passenger = await _appDbContext.Passengers.FindAsync(passengerId);
            _appDbContext.Remove(passenger);
        }

        public async Task<List<Passenger>> GetPassengersAsync()
        {
            List<Passenger> passenger = _appDbContext.Passengers.Include(m=>m.Fly).ToList();
            return passenger;
        }

        public async Task PassengerAddAsync(Passenger passenger)
        {
            await _appDbContext.Passengers.AddAsync(passenger);
        }
    }
}
