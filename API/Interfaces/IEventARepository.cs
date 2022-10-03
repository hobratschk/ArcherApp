using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IEventARepository
    {
        void Update(EventAScore eventAScore);

        void CreateEventAScore(EventAScore score);

        void DeleteEventAScore(EventAScore score);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<EventAScore>> GetEventAScoresAsync();

        Task<EventAScore> GetEventAScoreByArcherIdAsync(int id);

    }
}