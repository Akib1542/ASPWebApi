using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Properties.Commands
{
    public class CreatePropertyRequestHandler : IRequestHandler<CreatePropertyRequest, bool>
    {
        #region Fields

        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;

        #endregion

        #region CTOR

        public CreatePropertyRequestHandler(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public async Task<bool> Handle(CreatePropertyRequest request, CancellationToken cancellationToken)
        {
            Property property = _mapper.Map<Property>(request.propertyRequest);

            property.ListDate = DateTime.Now;
            await _propertyRepo.AddNewAsync(property);

            return true;
        }

        #endregion
    }
}
