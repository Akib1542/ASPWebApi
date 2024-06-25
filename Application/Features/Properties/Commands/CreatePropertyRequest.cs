using Application.Models;
using MediatR;

namespace Application.Features.Properties.Commands
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
