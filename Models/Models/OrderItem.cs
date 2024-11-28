using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }
        public int OrderItemId { get; set; }
        public int OrderId { get; set; } 
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
