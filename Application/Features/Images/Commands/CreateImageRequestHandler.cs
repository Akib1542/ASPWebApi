using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Images.Commands
{
    public class CreateImageRequestHandler : IRequestHandler<CreateImageRequest, bool>
    {
        #region Fields

        private readonly IImageRepo _imageRepo;
        private readonly IMapper _mapper;

        #endregion

        #region CTOR

        public CreateImageRequestHandler(IImageRepo imageRepo, IMapper mapper)
        {
            _imageRepo = imageRepo;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public async Task<bool> Handle(CreateImageRequest request, CancellationToken cancellationToken)
        {
            Image image = _mapper.Map<Image>(request.NewImage);
            await _imageRepo.AddNewAsync(image);
            return true;
        }

        #endregion
    }
}
