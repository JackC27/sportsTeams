using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamsApi.Models;


namespace TeamsApi.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        
        private readonly TeamsContext _context; 

        public TeamsController(TeamsContext context) //Neither is this.
        {
            _context = context;

            if (_context.Teams.Count() == 0)
            {
                // Create a new team if collection is empty,
                // which means you can't delete all teams.
                
                _context.Teams.Add(new Team { Name = "Item1" });
                _context.SaveChanges();
            }
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
            return await _context.Teams.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeams(long id)
        {
            var todoItem = await _context.Teams.FindAsync(id);

            if (todoItem == null)
            {
            return NotFound();
            }

            return todoItem;
        }
    }
}

