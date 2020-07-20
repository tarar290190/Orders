using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AggregatorService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AggregatorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderDetailsController : ControllerBase
    {
        private IOrderDetails _orderDetails;

        public orderDetailsController(IOrderDetails orderDetails)
        {
            this._orderDetails = orderDetails;
        }

        [HttpGet("{id}",Name = "Get")]
        public string Get(int id)
        {

            return _orderDetails.GetOrderDetails(id);
        }

    }
}