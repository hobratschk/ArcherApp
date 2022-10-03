using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class EventBController : BaseApiController
    {
        public IEventBRepository _eventBRepository { get; }
        public EventBController(IEventBRepository eventBRepository)
        {
            _eventBRepository = eventBRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IList<EventBScore>>> GetEventBScores()
        {
            var eventBScores = await _eventBRepository.GetEventBScoresAsync();
            // can sort here if I want
            return Ok(eventBScores);
        }

        // api/eventBScores/id
        [HttpGet("{id}")]
        public async Task<ActionResult<EventBScore>> GetEventBScore(int id)
        {
            return await _eventBRepository.GetEventBScoreByArcherIdAsync(id);
        }
    }
}