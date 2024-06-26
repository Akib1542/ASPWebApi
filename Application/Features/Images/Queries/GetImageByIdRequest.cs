using Application.Models;
using MediatR;

namespace Application.Features.Images.Queries
{
    public class GetImageByIdRequest : IRequest<ImageDTO>
    {
        #region CTOR

        public GetImageByIdRequest(int imageId)
        {
            ImageId = imageId;
        }

        #endregion

        #region Fields
 
        public int ImageId { get; set; }

        #endregion
    }
}
