using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Order
    {
        public List<Item> OrderItems { get; set; } = new List<Item>();
    }
}
