using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ArchersController : BaseApiController
    {
        private readonly DataContext _context;
        public ArchersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Archer>>> GetArchers()
        {
            var archers = await _context.Archers.ToListAsync();
            // can sort here if I want
            return archers;
        }

        // api/archers/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Archer>> GetArcher(int id)
        {
            return await _context.Archers.FindAsync(id);
        }
    }
}