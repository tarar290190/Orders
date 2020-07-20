using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Model
{
    public interface IOrderData
    {
        IEnumerable<Order> GetOrders(int id);
    }
}
