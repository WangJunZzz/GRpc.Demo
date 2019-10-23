using System.Threading.Tasks;
using Grpc.Core;
using GrpcService.Order;

namespace GrpcService.Orders.Api.Services
{
    public class OrderApiService : Order.OrderGrpcApiService.OrderGrpcApiServiceBase
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="request">在proto中定义的请求参数</param>
        /// <param name="context">GRPC API 提供对某些 HTTP/2 消息数据 (如方法、主机、标头和尾部) 的访问权限</param>
        /// <returns></returns>
        public override Task<OrderApiResponse> AddOrder(OrderApiRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OrderApiResponse
            {
                Id = request.Id,
                Msg = "下单成功-api"
            });
        }
    }
}
