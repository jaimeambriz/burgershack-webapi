using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class SidesController : Controller
    {

        public  static List<Side> Sides =  new List<Side>() {
                new Side() {
                    Id = 1,
                    Name = "Straight Up tatoe",
                    Description = "A plain old potatoe seasoned to perfection",
                    Price = 9.99 },
                new Side() {
                    Id = 2,
                    Name = "Cheese Burger fries",
                    Description = "Straight up fries with cheese, (Choose One: Provolone, Gouda, Munster, Swiss, Cheddar, Merican)",
                    Price = 10.99 } };
        // GET api/values
        [HttpGet]
        public IEnumerable<Side> Get()
        {
            return Sides;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Side Get(int id)
        {
            return Sides.FirstOrDefault(sides => sides.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //your job
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
