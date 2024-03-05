// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcServer;
using static GrpcServer.Customer;
using static GrpcServer.Greeter;

var channel = GrpcChannel.ForAddress("https://localhost:7278");

CustomerClient customerClient = new(channel);
GreeterClient client = new(channel);

CustomerLookupModel customerLookup = new() { UserId = 2 };

CustomerModel customer = customerClient.GetCustomerInfo(customerLookup);

HelloRequest inputRequest = new() { Name = "GreeterClient" };

HelloReply reply = await client.SayHelloAsync(inputRequest);


Console.WriteLine(reply.Message);
Console.WriteLine(customer.Name);

Console.ReadLine();
