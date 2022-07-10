using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
   public interface IPilotGaleryRepository
    {
        public Task PilotGaleryAddAsync(PilotGalery pilotGalery);
        public Task<List<PilotGalery>> GetPilotGaleries();

    }
}
