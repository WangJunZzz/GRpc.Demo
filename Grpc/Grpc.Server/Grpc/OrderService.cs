using Grpc.Core;
using OrderServices;
using System;
using System.Threading.Tasks;

namespace Grpc.Server.Grpc
{
    public class OrderService : OrderGrpcService.OrderGrpcServiceBase
    {
        public override Task<OrderInfoDTO> GetOrderById(RequestItem request, ServerCallContext context)
        {
            OrderInfoDTO order = new OrderInfoDTO();
            order.OrderId = request.OrderId;
            order.ProductId = Guid.NewGuid().ToString();
            order.ProductName = "Grpc";
            order.Price = "1250";
            order.Number = 2;
            return Task.FromResult(order);
        }
    }
}
