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
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(UserToAddOrUpdateDTO userToAddOrUpdateDTO)
        {
            User user = _mapper.Map<User>(userToAddOrUpdateDTO);
            await _unitOfWork.UserRepository.AddAsync(user);
            await _unitOfWork.Commit();

        }

        public async Task<List<UserToAddOrUpdateDTO>> GetUser()
        {
            List<User> users = await _unitOfWork.UserRepository.GetUser();
            List<UserToAddOrUpdateDTO> userToAddOrUpdateDTOs = _mapper.Map<List<UserToAddOrUpdateDTO>>(users);
            return userToAddOrUpdateDTOs;

        }
    }
}
