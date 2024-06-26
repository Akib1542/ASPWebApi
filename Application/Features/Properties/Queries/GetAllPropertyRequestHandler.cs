using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Properties.Queries
{
    public class GetAllPropertyRequestHandler : IRequestHandler<GetAllPropertyRequest, List<PropertyDto>>
    {
        #region Fields

        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;

        #endregion

        #region CTOR

        public GetAllPropertyRequestHandler(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public async Task<List<PropertyDto>> Handle(GetAllPropertyRequest request, CancellationToken cancellationToken)
        {
            List<Property> properties = await _propertyRepo.GetAllAsync();
            if (properties != null)
            {
                List<PropertyDto> propertyDTOs = _mapper.Map<List<PropertyDto>>(properties);
                return propertyDTOs;
            }
            return null;
        }

        #endregion
    }
}
