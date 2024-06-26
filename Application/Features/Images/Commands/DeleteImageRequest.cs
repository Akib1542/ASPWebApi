using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Images.Commands
{
    public class DeleteImageRequest : IRequest<bool>
    {
        #region Fields

        public int ImageId { get; set; }

        #endregion

        #region CTOR

        public DeleteImageRequest(int imageId)
        {
            ImageId = imageId;
        }

        #endregion
    }
}
