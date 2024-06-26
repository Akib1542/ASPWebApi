using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;


namespace Application.Features.Properties.Queries
{
    public class GetPropertyByIdRequestHandler : IRequestHandler<GetPropertyByIdRequest, PropertyDto>
    {
        #region Fields

        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;

        #endregion

        #region CTOR

        public GetPropertyByIdRequestHandler(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public async Task<PropertyDto> Handle(GetPropertyByIdRequest request, CancellationToken cancellationToken)
        {
            Property propertyInDb = await _propertyRepo.GetByIdAsync(request.PropertyId);
            if (propertyInDb != null)
            {
                var propertyDto = _mapper.Map<PropertyDto>(propertyInDb);
                return propertyDto;
            }
            return null;
        }

        #endregion
    }
}
