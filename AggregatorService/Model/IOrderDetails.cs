using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorService.Model
{
    public interface IOrderDetails
    {
        string GetOrderDetails(int id);
    }
}
