using Application.Models;
using MediatR;

namespace Application.Features.Properties.Commands
{
    public class CreatePropertyRequest : IRequest<bool>
    {
        #region Fields

        public NewProperty propertyRequest { get; set; }

        #endregion

        #region CTOR

        public CreatePropertyRequest(NewProperty newPropertyRequest)
        {
            propertyRequest = newPropertyRequest;
        }

        #endregion
    }
}
