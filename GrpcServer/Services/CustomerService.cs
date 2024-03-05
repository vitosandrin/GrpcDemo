using Grpc.Core;

namespace GrpcServer.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new();

            if (request.UserId == 1)
            {
                output.Name = "John";
            }
            else if (request.UserId == 2)
            {
                output.Name = "Jane";
            }
            else
            {
                output.Name = "No User";
            }

            return Task.FromResult(output);
        }

    }
}
