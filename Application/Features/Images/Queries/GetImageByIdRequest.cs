using Application.Models;
using MediatR;

namespace Application.Features.Images.Queries
{
    public class GetImageByIdRequest : IRequest<ImageDTO>
    {
        public GetImageByIdRequest(int imageId)
        {
            ImageId = imageId;
        }
        public int ImageId { get; set; }
    }
}
