using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;


namespace Application.Properties.Queries
{
    public class GetPropertyByIdRequestHandler : IRequestHandler<GetPropertyByIdRequest,Property>
    {
        private readonly IPropertyRepo _propertyRepo;
        public GetPropertyByIdRequestHandler(IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }

        public async Task<Property> Handle(GetPropertyByIdRequest request, CancellationToken cancellationToken)
        {
            var propertyInDb = await _propertyRepo.GetByIdAsync(request.PropertyId);
            if(propertyInDb!=null)
            {
                return propertyInDb;
            }
            return null;
        }
    }
}
