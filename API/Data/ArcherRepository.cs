using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ArcherRepository : IArcherRepository
    {
        private readonly DataContext _context;
        public ArcherRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Archer> GetArcherByIdAsync(int id)
        {
            return await _context.Archers.FindAsync(id);
        }

        public async Task<IEnumerable<Archer>> GetArchersAsync()
        {
            return await _context.Archers.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Archer archer)
        {
            _context.Entry(archer).State = EntityState.Modified;
        }

        public void DeleteArcher(Archer archer)
        {
            _context.Archers.Remove(archer);
        }

        public void CreateArcher(Archer archer)
        {
             _context.Archers.Add(archer);
        }
    }
}