using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST_API_Demo.Models;


namespace REST_API_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ValuesController : ControllerBase
    {
        private UserContext db;
        public ValuesController(UserContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<tblRequesTest>>> Get()
        {
            return await db.tblRequesTest.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<tblRequesTest>> Get(int id)
        {
            tblRequesTest Req = await db.tblRequesTest.FirstOrDefaultAsync(x => x.Id == id);
            if (Req == null)
                return NotFound();
            return new ObjectResult(Req);
        }


        [HttpPut]
        public async Task<ActionResult<tblRequesTest>> Put(tblRequesTest Req)
        {
            if (Req == null)
                return BadRequest();
            if (!db.tblRequesTest.Any(x => x.Id == Req.Id))
                return NotFound();
            db.Update(Req);
            await db.SaveChangesAsync();
            return Ok(Req);
        }

        [HttpPost]
        public async Task<ActionResult<tblRequesTest>> Post(tblRequesTest Req)
        {
            if (Req == null)
                return BadRequest();
            db.tblRequesTest.Add(Req);
            await db.SaveChangesAsync();
            return Ok(Req);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<tblRequesTest>> Delete(int id)
        {
            tblRequesTest Req = db.tblRequesTest.FirstOrDefault(x => x.Id == id);
            if (Req == null)
                return NotFound();
            db.tblRequesTest.Remove(Req);
            await db.SaveChangesAsync();
            return Ok(Req);
        }

    }
}
