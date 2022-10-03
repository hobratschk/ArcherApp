using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class EventARepository : IEventARepository
    {
        private readonly DataContext _context;
        public EventARepository(DataContext context)
        {
            _context = context;
        }

        public async Task<EventAScore> GetEventAScoreByArcherIdAsync(int id)
        {
            return await _context.EventAScores.FindAsync(id);
        }

        public async Task<IEnumerable<EventAScore>> GetEventAScoresAsync()
        {
            return await _context.EventAScores.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void CreateEventAScore(EventAScore eventAScore)
        {
            _context.EventAScores.Add(eventAScore);
        }

        public void DeleteEventAScore(EventAScore eventAScore)
        {
            _context.EventAScores.Remove(eventAScore);
        }
        public void Update(EventAScore eventAScore)
        {
            _context.Entry(eventAScore).State = EntityState.Modified;
        }

        
    }
}