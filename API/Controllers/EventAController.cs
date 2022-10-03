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
    public class EventAController : BaseApiController
    {
        private readonly IEventARepository _eventARepository;
        private readonly IArcherRepository _archerRepository;
        public EventAController(IArcherRepository archerRepository, IEventARepository eventARepository)
        {
            _eventARepository = eventARepository;
            _archerRepository = archerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IList<EventAScore>>> GetEventAScores()
        {
            var eventAScores = await _eventARepository.GetEventAScoresAsync();
            // can sort here if I want
            return Ok(eventAScores);
        }

        // api/eventAScores/id
        [HttpGet("{id}")]
        public async Task<ActionResult<EventAScore>> GetEventAScore(int id)
        {
            return await _eventARepository.GetEventAScoreByArcherIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<EventAScore>> CreateEventAScore(EventAScore eventAScore)
        {
            // var scoreA = new EventAScore
            // {
            //     ArcherId = eventAScore.ArcherId,
            //     Archer = eventAScore.Archer,
            //     TargetA = eventAScore.TargetA,
            //     TargetB = eventAScore.TargetB,
            //     TargetC = eventAScore.TargetC,
            //     TargetD = eventAScore.TargetD,
            //     TargetE = eventAScore.TargetE,
            //     TargetF = eventAScore.TargetF,
            // };
            _eventARepository.CreateEventAScore(eventAScore);
            if (await _eventARepository.SaveAllAsync()) return Ok();

            return BadRequest("Failed to save.");
        }

        [HttpPut]
        public async Task<ActionResult<EventAScore>> UpdateEventAScore(EventAScore eventAScore)
        {
            _eventARepository.Update(eventAScore);
            if (await _eventARepository.SaveAllAsync()) return Ok();

            return BadRequest("Failed to update.");
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEventAScore(EventAScore eventAScore)
        {
            _eventARepository.DeleteEventAScore(eventAScore);
            if (await _eventARepository.SaveAllAsync()) return Ok();

            return BadRequest("Failed to delete.");
        }
    }
}