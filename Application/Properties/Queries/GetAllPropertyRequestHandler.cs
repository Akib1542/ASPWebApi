using Application.Repositories;
using Domain;
using MediatR;

namespace Application.Properties.Queries
{
    public class GetAllPropertyRequestHandler : IRequestHandler<GetAllPropertyRequest, List<Property>>
    {
        private readonly IPropertyRepo _propertyRepo;

        public GetAllPropertyRequestHandler(IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }
        public async Task<List<Property>> Handle(GetAllPropertyRequest request, CancellationToken cancellationToken)
        {
            var propertyInDb = await _propertyRepo.GetAllAsync();
            if(propertyInDb!=null)
            {
                return propertyInDb;
            }
            return null;
        }
    }
}
