using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;


namespace Application.Features.Properties.Queries
{
    public class GetPropertyByIdRequestHandler : IRequestHandler<GetPropertyByIdRequest, PropertyDto>
    {
        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;
        public GetPropertyByIdRequestHandler(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }

        public async Task<PropertyDto> Handle(GetPropertyByIdRequest request, CancellationToken cancellationToken)
        {
            Property propertyInDb = await _propertyRepo.GetByIdAsync(request.PropertyId);
            if (propertyInDb != null)
            {
                var propertyDtos = _mapper.Map<PropertyDto>(propertyInDb);
                return propertyDtos;
            }
            return null;
        }
    }
}
