using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Images.Queries
{
    public class GetImageByIdRequestHandler : IRequestHandler<GetImageByIdRequest, ImageDTO>
    {
        private readonly IImageRepo _imageRepo;
        private readonly IMapper _mapper;

        public GetImageByIdRequestHandler(IImageRepo imageRepo, IMapper mapper)
        {
            _imageRepo = imageRepo;
            _mapper = mapper;
        }

        public async Task<ImageDTO> Handle(GetImageByIdRequest request, CancellationToken cancellationToken)
        {
            Image imageInDb = await _imageRepo.GetByIdAsync(request.ImageId);
            if(imageInDb != null)
            {
                ImageDTO imageDTO = _mapper.Map<ImageDTO>(imageInDb);
                return imageDTO;
            }
            return null;
        }
    }
}
