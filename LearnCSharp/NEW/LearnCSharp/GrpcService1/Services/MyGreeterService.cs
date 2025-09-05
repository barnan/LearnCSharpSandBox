using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcService1.Protos;

using System.Xml.Linq;

namespace GrpcService1.Services
{
    public class MyGreeterService : GreeterService2Base
    {
        public async override Task<MyGreetUserResponse> GreetUser(MyGreetUserRequest request, ServerCallContext context)
        {
            return new MyGreetUserResponse
            {
                GreetingMessage = "Szia kedves " + request.UserName + " !"
            };
        }


        public async override Task<Empty> GreetMultipleUsers(MyGreetMultipleUsersRequest request, ServerCallContext context)
        {
            foreach (string name in request.UserNames)
            {
                Console.WriteLine("Szia " + name + " Jó h itt vagy!");

            }

            return new Empty();
        }

        public async override Task GreetMultipleUsersStream(IAsyncStreamReader<MyGreetUserRequest> requestStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                Console.WriteLine("Szia " + requestStream.Current.UserName + " Jó h itt vagy!");
                await Task.Delay(300);
            }


        }
    }
}
