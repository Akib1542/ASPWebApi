using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Images.Commands
{
    public class UpdateImageRequest : IRequest<bool>
    {
        #region Fields

        public UpdateImage UpdateImage { get; set; }

        #endregion

        #region Method

        public UpdateImageRequest(UpdateImage updateImage)
        {
            UpdateImage = updateImage;
        }

        #endregion
    }
}
