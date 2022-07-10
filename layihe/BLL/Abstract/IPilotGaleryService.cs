using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IPilotGaleryService
    {
        public Task PilotGaleryAddAsync(PilotGaleryToAddDTO pilotGaleryToAddDTO);
        public Task<List<PilotGaleryToGetDTO>> GetPilotGaleries();
    }
}
