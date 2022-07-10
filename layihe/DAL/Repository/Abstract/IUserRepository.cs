using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
    public interface IUserRepository
    {
        public Task AddAsync(User user);
        public Task<List<User>> GetUser();
    }
}
