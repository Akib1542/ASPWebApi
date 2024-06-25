using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Properties.Queries
{
    public class GetAllPropertyRequestHandler : IRequestHandler<GetAllPropertyRequest, List<PropertyDto>>
    {
        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;

        public GetAllPropertyRequestHandler(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }
        public async Task<List<PropertyDto>> Handle(GetAllPropertyRequest request, CancellationToken cancellationToken)
        {
            List<Property> propertyInDb = await _propertyRepo.GetAllAsync();
            if (propertyInDb != null)
            {
                List<PropertyDto> propertyDTOs = _mapper.Map<List<PropertyDto>>(propertyInDb);
                return propertyDTOs;
            }
            return null;
        }
    }
}
