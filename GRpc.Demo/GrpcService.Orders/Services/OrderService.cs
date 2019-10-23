using System.Threading.Tasks;
using Grpc.Core;
using GrpcService.Order;

namespace GrpcService.Orders.Services
{
    public class OrderService : Order.OrderGrpcService.OrderGrpcServiceBase
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="request">在proto中定义的请求参数</param>
        /// <param name="context">GRPC API 提供对某些 HTTP/2 消息数据 (如方法、主机、标头和尾部) 的访问权限</param>
        /// <returns></returns>
        public override Task<OrderResponse> AddOrder(OrderRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OrderResponse
            {
                Id = request.Id,
                Msg = "下单成功"
            });
        }
    }
}
