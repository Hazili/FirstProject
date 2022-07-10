using DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; set; }
        public IFlyRepository FlyRepository { get; set; }
        public ICityRepository CityRepository { get; set; }
        public IPilotGaleryRepository PilotGaleryRepository { get; set; }
        public IPassengerRepository PassengerRepository {get; set; }
        public IDepartureCityRepository DepartureCityRepository { get; set; }
        Task Commit();
    }
}
