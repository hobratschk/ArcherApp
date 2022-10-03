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
    public class ArchersController : BaseApiController
    {
        public IArcherRepository _archerRepository { get; }
        public ArchersController(IArcherRepository archerRepository)
        {
            _archerRepository = archerRepository;
        }

        [HttpPost]
        public async Task<ActionResult<EventAScore>> CreateArcher(Archer archer)
        {
            _archerRepository.CreateArcher(archer);
            if (await _archerRepository.SaveAllAsync()) return Ok();
            return BadRequest("Failed to add the archer.");
        }
          

        [HttpGet]
        public async Task<ActionResult<IList<Archer>>> GetArchers()
        {
            var archers = await _archerRepository.GetArchersAsync();
            // can sort here if I want
            return Ok(archers);
        }

        // api/archers/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Archer>> GetArcher(int id)
        {
            return await _archerRepository.GetArcherByIdAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteArcher(Archer archer)
        {
            _archerRepository.DeleteArcher(archer);
            if (await _archerRepository.SaveAllAsync()) return Ok();

            return BadRequest("Failed to delete.");
        }
    }
}