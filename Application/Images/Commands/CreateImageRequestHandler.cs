﻿using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Images.Commands
{
    public class CreateImageRequestHandler : IRequestHandler<CreateImageRequest, bool>
    {
        private readonly IImageRepo _imageRepo;
        private readonly IMapper _mapper;

        public CreateImageRequestHandler(IImageRepo imageRepo, IMapper mapper) 
        {
            _imageRepo = imageRepo;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateImageRequest request, CancellationToken cancellationToken)
        {
            Image image = _mapper.Map<Image>(request.NewImage);
            await _imageRepo.AddNewAsync(image);
            return true;
        }
    }
}
