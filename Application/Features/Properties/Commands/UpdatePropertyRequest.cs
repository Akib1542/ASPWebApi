using Application.Models;
using MediatR;

namespace Application.Features.Properties.Commands
{
    public class UpdatePropertyRequest : IRequest<bool>
    {
        #region Fields

        public UpdateProperty UpdateProperty { get; set; }

        #endregion

        #region CTOR

        public UpdatePropertyRequest(UpdateProperty updateProperty)
        {
            UpdateProperty = updateProperty;
        }

        #endregion
    }
}
