using HamsterWarz.Server.Data;
using HamsterWarz.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HamsterWarz.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamsterController : ControllerBase
    {
        
        private readonly HamsterWarzContext _context;

        public HamsterController(HamsterWarzContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Hamster>>> Get()
        {
            var hamsters = await _context.Hamsters.ToListAsync();
            return Ok(hamsters);
            
        }
        [HttpGet("{id}")]

        [HttpGet("{id}")]
        public async Task<ActionResult<Hamster>> Get(int id)
        {

            var hamster = await _context.Hamsters
                 .FirstOrDefaultAsync(h => h.Id == id);
            if (hamster == null)
            {
                return NotFound("Sorry, no hamster here. :/");
            }
            return Ok(hamster);
        }
        [HttpPost]
        public async Task<ActionResult<List<Hamster>>> AddHero(Hamster hamster)
        {

            _context.Hamsters.Add(hamster);
            await _context.SaveChangesAsync();

            return Ok(await GetDbHamsters());
        }
        [HttpPut]
        public async Task<ActionResult<List<Hamster>>> UpdateHamster(Hamster hamster,int id)
        {
            var dbHamster = await _context.Hamsters
                 .FirstOrDefaultAsync(sh => sh.Id == id);
            if (dbHamster == null)
                return NotFound("Sorry, but no hamster for you. :/");

            dbHamster.Name = hamster.Name;
            dbHamster.Age = hamster.Age;
            dbHamster.FavFood = hamster.FavFood;
            dbHamster.Loves = hamster.Loves;
            dbHamster.ImgName = hamster.ImgName;
            dbHamster.Wins = hamster.Wins;
            dbHamster.Losses = hamster.Losses;
            dbHamster.Games = hamster.Games;


        await _context.SaveChangesAsync();

            return Ok(await GetDbHamsters());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Hamster>>> DeleteHamster(int id)
        {
            var dbHamster = await _context.Hamsters
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (dbHamster == null)
                return NotFound("Sorry, but no hamster for you. :/");

            _context.Hamsters.Remove(dbHamster);
            await _context.SaveChangesAsync();

            return Ok(await GetDbHamsters());
        }

        private async Task<List<Hamster>> GetDbHamsters()
        {
            return await _context.Hamsters.ToListAsync();
        }
       
        [HttpGet("Hamsters/random")]
        public async Task<ActionResult<Hamster>> GetRandomHamster()
        {
            List<Hamster> hamsters = await _context.Hamsters.ToListAsync();
            if (hamsters.Count > 0)
            {
                Random random = new Random();
                return Ok(hamsters[random.Next(0, hamsters.Count)]);
            }
            else return NotFound("No Hamsters Found");
        }
    }
}
