using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
    public interface IFlyRepository
    {
        public Task AddAsync(Fly fly );
        public Task<List<Fly>> GetFliesAsync();

        public Task DeleteFlyAsync(int flyId);

    }
}
