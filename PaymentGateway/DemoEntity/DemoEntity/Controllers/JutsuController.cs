using Microsoft.AspNetCore.Mvc;
using DemoEntity.Entities;
using DemoEntity.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DemoEntity.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JutsuController : Controller
    {

        private readonly DataContext _dataContext;

        public JutsuController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Jutsu>>> GetAllJutsu()
        {
            var Jutsu = await _dataContext.Jutsus.ToListAsync(); 
            return Ok(Jutsu);//returns 200 or 404
       }

        [HttpGet("{id}")]
        public async Task<ActionResult<Jutsu>> GetJutsu(int id)
        {
            var Jutsu = await _dataContext.Jutsus.FindAsync(id);
            if (Jutsu == null )
            {
                return NotFound("Hero not found");
            }

            return Ok(Jutsu);//returns 200 or 404
        }

        [HttpPost]
        public async Task<ActionResult<List<Jutsu>>> CreateJutsu(Jutsu jutsu)
        {
            _dataContext.Jutsus.Add(jutsu);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Jutsus.ToListAsync()); //returns 200 or 404
        }
        [HttpPut]
        public async Task<ActionResult<List<Jutsu>>> UpdateJutsu(Jutsu jutsu)
        {
            var dbJutsu = await _dataContext.Jutsus.FindAsync(jutsu.JutsuId);
            if (dbJutsu == null)
            {
                return NotFound("Hero not found");
            }
            dbJutsu.JutsuDescription = jutsu.JutsuDescription;  
            dbJutsu.JutsuName = jutsu.JutsuName;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Jutsus.ToListAsync()); //returns 200 or 404
        }

        [HttpDelete]
        public async Task<ActionResult<List<Jutsu>>> DeleteJutsu(int id)
        {
            var dbJutsu = await _dataContext.Jutsus.FindAsync(id);
            if (dbJutsu == null)
            {
                return NotFound("Hero not found");
            }
         

            _dataContext.Jutsus.Remove(dbJutsu);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Jutsus.ToListAsync()); //returns 200 or 404
        }
    }
}
