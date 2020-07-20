using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Model
{
    public class Order
    {
       // public int UserId { get; set; }
        public int orderId { get; set; }
        public double orderAmount { get; set; }
        public String orderDate { get; set; }
    }
}
