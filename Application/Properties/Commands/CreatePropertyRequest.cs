using Application.Models;
using MediatR;

namespace Application.Properties.Commands
{
    public class CreatePropertyRequest : IRequest<bool>
    {
        public NewProperty propertyRequest { get; set; }
        public CreatePropertyRequest(NewProperty newPropertyRequest)
        {
            propertyRequest = newPropertyRequest;
        }
    }
}
