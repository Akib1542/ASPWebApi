using Application.Models;
using MediatR;

namespace Application.Features.Images.Commands
{
    public class CreateImageRequest : IRequest<bool>
    {
        #region Fields
        public NewImage NewImage { get; set; }

        #endregion

        #region CTOR

        public CreateImageRequest(NewImage newImage)
        {
            NewImage = newImage;
        }

        #endregion

    }
}
