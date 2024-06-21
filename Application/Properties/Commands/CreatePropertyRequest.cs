using Application.Models;
using MediatR;

namespace Application.Properties.Commands
{
    public class CreatePropertyRequest : IRequest<bool>
    {
        public NewPropertyRequest propertyRequest { get; set; }
        public CreatePropertyRequest(NewPropertyRequest newPropertyRequest)
        {
            propertyRequest = newPropertyRequest;
        }
    }
}
