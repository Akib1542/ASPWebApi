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

namespace Application.Features.Images.Queries
{
    public class GetImagesRequestHandler : IRequestHandler<GetImagesRequest, List<ImageDTO>>
    {
        #region Fields

        private readonly IImageRepo _imageRepo;
        private readonly IMapper _mapper;

        #endregion

        #region CTOR

        public GetImagesRequestHandler(IImageRepo imageRepo, IMapper mapper)
        {
            _imageRepo = imageRepo;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public async Task<List<ImageDTO>> Handle(GetImagesRequest request, CancellationToken cancellationToken)
        {
            List<Image> images = await _imageRepo.GetAllAsync();
            if (images != null)
            {
                List<ImageDTO> imageDTOs = _mapper.Map<List<ImageDTO>>(images);
                return imageDTOs;
            }
            return null;
        }

        #endregion
    }
}
