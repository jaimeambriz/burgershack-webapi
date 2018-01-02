using System.Collections.Generic;
using burgershack_c.Controllers;

namespace burgershack_c.Models
{

    public class Menu
    {
        public List<Burger> Burgers {get; set;}
        public List<Drink> Drinks {get; set;}
        public List<Side> Sides {get; set;}
    }
}