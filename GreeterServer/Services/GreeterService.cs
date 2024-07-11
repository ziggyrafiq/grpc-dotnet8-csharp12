using Grpc.Core;
namespace GreeterServer.Services;
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        try
        {
            var reply = new HelloReply
            {
                Message = $"Hello, {request.Name}"
            };
            _logger.LogInformation($"GRPC Request Send and Recived");
            return Task.FromResult(reply);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error while handing your request {ex.Message}");
            throw;
        }
        
    }
}
