using Grpc.Net.Client;
using GrpcService.Order;
using System;

namespace GrpcService.Orders.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new  OrderGrpcService.OrderGrpcServiceClient(channel);
            //var response = client.AddOrder(new OrderRequest
            //{
            //    Id = 11,
            //    Name = "98k",
            //    Price = 556,
            //    Remark = "测试"
            //});

            var channel = GrpcChannel.ForAddress("https://localhost:5002");
            var client = new OrderGrpcApiService.OrderGrpcApiServiceClient(channel);
            var response = client.AddOrder(new OrderApiRequest
            {
                Id = 11,
                Name = "98k",
                Price = 556,
                Remark = "测试"
            });
            Console.WriteLine(response);
            Console.ReadKey();
        }
    }
}
