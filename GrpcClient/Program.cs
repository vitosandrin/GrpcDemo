// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcServer;
using static GrpcServer.Greeter;

var channel = GrpcChannel.ForAddress("https://localhost:7278");

GreeterClient client = new(channel);

HelloRequest inputRequest = new() { Name = "GreeterClient" };

HelloReply reply = await client.SayHelloAsync(inputRequest);

Console.WriteLine(reply.Message);

Console.ReadLine();
