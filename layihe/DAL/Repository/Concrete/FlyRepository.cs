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
    public class FlyRepository : IFlyRepository
    {
        private readonly AppDbContext _appDbContext;
        public FlyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AddAsync(Fly fly)
        {
            await _appDbContext.Flies.AddAsync(fly);
        }

        public async Task DeleteFlyAsync(int flyId)
        {
           Fly fly =  await _appDbContext.Flies.FindAsync(flyId);
            _appDbContext.Flies.Remove(fly);

        }

        public async Task<List<Fly>> GetFliesAsync()
        {
            List<Fly> flies = _appDbContext.Flies.Include(m=>m.City).ToList(); 
            return flies;
        }

        //public async Task<List<Fly>> GetFliesForLIstBoxAsync()
        //{
        //  //  List<City> cities = _appDbContext.Cities.ToList();
        //    List<Fly> fly = _appDbContext.Flies.Include(x => x.City).ToList();

        //    return fly;
        //}
    }
}
