using AutoMapper;
using BLL.Abstract;
using DAL.UnitOfWork;
using DTO.DTOs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class PilotGaleryService : IPilotGaleryService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PilotGaleryService(IMapper mapper, IUnitOfWork unitOfWork) 
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<PilotGaleryToGetDTO>> GetPilotGaleries()
        {
            List<PilotGalery> pilotGalery = await _unitOfWork.PilotGaleryRepository.GetPilotGaleries();
            List<PilotGaleryToGetDTO> pilotGaleryToGetDTO = _mapper.Map<List<PilotGaleryToGetDTO>>(pilotGalery);
            return pilotGaleryToGetDTO;
        }

        public async Task PilotGaleryAddAsync(PilotGaleryToAddDTO pilotGaleryToAddDTO)
        {
            PilotGalery pilotGalery =  _mapper.Map<PilotGalery>(pilotGaleryToAddDTO);
            await _unitOfWork.PilotGaleryRepository.PilotGaleryAddAsync(pilotGalery);
            await _unitOfWork.Commit();
        }
    }
}
