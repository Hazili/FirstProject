using DAL.DataContext;
using DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext, IUserRepository userRepository, IFlyRepository flyRepository, ICityRepository cityRepository, IPilotGaleryRepository pilotGaleryRepository, IPassengerRepository passengerRepository, IDepartureCityRepository departureCityRepository)
        {
            _appDbContext = appDbContext;
            UserRepository = userRepository;
            FlyRepository = flyRepository;
            CityRepository = cityRepository;
            PilotGaleryRepository = pilotGaleryRepository;
            PassengerRepository = passengerRepository;
            DepartureCityRepository = departureCityRepository;

        }
        public IUserRepository UserRepository { get; set; }
        public IFlyRepository FlyRepository { get; set; }
        public ICityRepository CityRepository { get; set; }
        public IPilotGaleryRepository PilotGaleryRepository { get; set; }
        public IPassengerRepository PassengerRepository { get; set; }
        public IDepartureCityRepository DepartureCityRepository { get; set; }
        public async Task Commit()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
