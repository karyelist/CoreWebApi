using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Models;

namespace Web_Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        ApiDbContext _context;

        public DefaultController(ApiDbContext apiDbContext)
        {
            _context = apiDbContext;
        }
        // GET: api/Default
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var list = _context.TestTable.ToList();
             return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
