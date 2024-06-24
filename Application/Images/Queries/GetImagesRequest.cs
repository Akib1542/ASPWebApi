using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Images.Queries
{
    public class GetImagesRequest : IRequest<List<ImageDTO>>
    {
    }
}
