using Application.Repositories;
using Domain;
using MediatR;

namespace Application.Features.Properties.Commands
{
    public class UpdatePropertyRequestHandler : IRequestHandler<UpdatePropertyRequest, bool>
    {
        private readonly IPropertyRepo _propertyRepo;
        public UpdatePropertyRequestHandler(IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }
        public async Task<bool> Handle(UpdatePropertyRequest request, CancellationToken cancellationToken)
        {
            //Check if the record exist in DB
            Property propertyInDb = await _propertyRepo.GetByIdAsync(request.UpdateProperty.Id);
            if (propertyInDb != null)
            {
                // if exists => update else return 
                propertyInDb.Name = request.UpdateProperty.Name;
                propertyInDb.Lounge = request.UpdateProperty.Lounge;
                propertyInDb.Dining = request.UpdateProperty.Dining;
                propertyInDb.price = request.UpdateProperty.price;
                propertyInDb.Rates = request.UpdateProperty.Rates;
                propertyInDb.Bathrooms = request.UpdateProperty.Bathrooms;
                propertyInDb.Bedrooms = request.UpdateProperty.Bedrooms;
                propertyInDb.ErfSize = request.UpdateProperty.ErfSize;
                propertyInDb.FloorSize = request.UpdateProperty.FloorSize;
                propertyInDb.Kitchens = request.UpdateProperty.Kitchens;
                propertyInDb.Levies = request.UpdateProperty.Levies;
                propertyInDb.PetsAllowed = request.UpdateProperty.PetsAllowed;
                propertyInDb.Address = request.UpdateProperty.Address;
                propertyInDb.Description = request.UpdateProperty.Description;
                propertyInDb.Type = request.UpdateProperty.Type;

                await _propertyRepo.UpdateAsync(propertyInDb);
                return true;
            }
            return false;

        }
    }
}
