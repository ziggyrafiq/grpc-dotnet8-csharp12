using GreeterServer;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7273");
var client = new Greeter.GreeterClient(channel);
Console.WriteLine("Hello from Ziggy Rafiq");
Console.WriteLine("Please Enter Your Name:");
string name = Console.ReadLine()?? "Missing Your Name !!";
var response = await client.SayHelloAsync(new HelloRequest{ Name = name });
Console.WriteLine(response);
Console.ReadLine();
