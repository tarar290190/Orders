using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderService.Model;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderData _orderData;

        public OrderController(IOrderData orderData)
        {
            this._orderData = orderData;
        }

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
           // Thread.Sleep(200);
            return JsonConvert.SerializeObject(_orderData.GetOrders(id));
        }
    }
}