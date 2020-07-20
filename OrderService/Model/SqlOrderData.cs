using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.Model
{
    public class SqlOrderData : IOrderData
    {

        //private readonly OrderDbContext _db;

        //public SqlOrderData(OrderDbContext db)
        //{
        //    this._db = db;
        //}
        public IEnumerable<Order> GetOrders(int id)
        {
            
            var orders= new List<Order>
            {
                new Order{   
                    orderId= 1,
                    orderAmount= 250,
                    orderDate="14-Apr-2020"
                         },

                new Order{
                    orderId= 2,
                    orderAmount= 250,
                    orderDate="14-Apr-2020"
                        }
            };

           // Thread.Sleep(100);

            return orders;
        }
    }
}
