﻿using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Properties.Commands
{
    public class CreatePropertyRequestHandler : IRequestHandler<CreatePropertyRequest, bool>
    {
        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;
        public CreatePropertyRequestHandler(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreatePropertyRequest request, CancellationToken cancellationToken)
        {
            Property property = _mapper.Map<Property>(request.propertyRequest);
            await _propertyRepo.AddNewAsync(property);  
            
            return true;
        }
    }
}
