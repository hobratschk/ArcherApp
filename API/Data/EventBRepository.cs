using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class EventBRepository : IEventBRepository
    {
        private readonly DataContext _context;
        public EventBRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<EventBScore> GetEventBScoreByArcherIdAsync(int id)
        {
            return await _context.EventBScores.FindAsync(id);
        }

        public async Task<IEnumerable<EventBScore>> GetEventBScoresAsync()
        {
            return await _context.EventBScores.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(EventBScore eventBScore)
        {
            _context.Entry(eventBScore).State = EntityState.Modified;
        }
    }
}