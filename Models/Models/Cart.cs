using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Cart
    {
        public Cart()
        {
            
        }
        public int CartId { get; set; }
        public int UserId { get; set; } 
        public int ProductId { get; set; } 
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
