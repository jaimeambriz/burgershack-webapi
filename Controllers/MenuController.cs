using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        public List<Menu> Menu = new List<Menu> (){

           new Menu(){
               Burgers = Program.Burgers,
               Drinks = Program.Drinks,
               Sides = burgershack_c.Controllers.SidesController.Sides
           }
                

        };
        // GET api/values
        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return Menu;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "value";
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
