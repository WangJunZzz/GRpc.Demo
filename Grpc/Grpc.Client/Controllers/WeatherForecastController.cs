using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderServices;

namespace Grpc.Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly OrderGrpcService.OrderGrpcServiceClient orderGrpcServiceClient;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,OrderGrpcService.OrderGrpcServiceClient orderGrpcServiceClient)
        {
            _logger = logger;
            this.orderGrpcServiceClient = orderGrpcServiceClient;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var result = orderGrpcServiceClient.GetOrderById(new RequestItem() { OrderId = Guid.NewGuid().ToString() });
            return Ok(result);
        }
    }
}
