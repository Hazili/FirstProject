using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IUserService
    {
        public Task AddAsync(UserToAddOrUpdateDTO userToAddOrUpdateDTO);
        public Task<List<UserToAddOrUpdateDTO>> GetUser();
       
    }
}
