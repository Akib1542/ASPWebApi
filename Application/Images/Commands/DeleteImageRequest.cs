using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Images.Commands
{
    public class DeleteImageRequest : IRequest<bool>
    {
        public int ImageId { get; set; }

        public DeleteImageRequest(int imageId)
        {
            ImageId = imageId;
        }
    }
}
