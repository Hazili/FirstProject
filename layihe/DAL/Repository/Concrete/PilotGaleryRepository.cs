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
    public class PilotGaleryRepository : IPilotGaleryRepository 
    {
        private readonly AppDbContext _appDbContext;
        public PilotGaleryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<PilotGalery>> GetPilotGaleries()
        {
            List<PilotGalery> pilotGalery =  _appDbContext.PilotGaleries.ToList();
            return pilotGalery;
        }

        public async Task PilotGaleryAddAsync(PilotGalery pilotGalery)
        {
           await _appDbContext.PilotGaleries.AddAsync(pilotGalery);
        }
    }
}
