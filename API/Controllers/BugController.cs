using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BugController : BaseApiController
    {
        private readonly DataContext _context;
        public BugController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("not-found")]
        public ActionResult<Archer>GetNotFound()
        {
            var thing = _context.Archers.Find(-1);

            if (thing == null) return NotFound();

            return Ok(thing);
        }

        [HttpGet("server-error")]
        public ActionResult<string>GetServerError()
        {
                var thing = _context.Archers.Find(-1);
                var thingToReturn = thing.ToString();
                return thingToReturn;
            
        }

        [HttpGet("bad-request")]
        public ActionResult<string>GetBadRequest()
        {
            return BadRequest("This was a not a valid request");
        }
    }
}