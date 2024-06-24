using Application.Models;
using MediatR;

namespace Application.Images.Commands
{
    public class CreateImageRequest : IRequest<bool>
    {
        public NewImage NewImage { get; set; }
        public CreateImageRequest(NewImage newImage)
        {
            NewImage = newImage;
        }
    }
}
