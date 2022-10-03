using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IArcherRepository
    {
        void Update(Archer archer);
        void CreateArcher(Archer archer);
        void DeleteArcher(Archer archer);

        Task<bool> SaveAllAsync();
        Task<IEnumerable<Archer>> GetArchersAsync();
        Task<Archer> GetArcherByIdAsync(int id);
    }
}