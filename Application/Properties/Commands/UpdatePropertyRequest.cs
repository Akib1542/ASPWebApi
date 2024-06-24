using Application.Models;
using MediatR;

namespace Application.Properties.Commands
{
    public class UpdatePropertyRequest : IRequest<bool>
    {
        public UpdateProperty UpdateProperty { get; set; }

        public UpdatePropertyRequest(UpdateProperty updateProperty)
        {
            UpdateProperty = updateProperty;
        }
    }
}
