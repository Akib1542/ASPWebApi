using Application.Repositories;
using Domain;
using MediatR;

namespace Application.Features.Properties.Commands
{
    public class DeletePropertyRequestHandler : IRequestHandler<DeletePropertyRequest, bool>
    {
        #region Fields

        private readonly IPropertyRepo _propertyRepo;

        #endregion

        #region CTOR

        public DeletePropertyRequestHandler(IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }

        #endregion

        #region Methods

        public async Task<bool> Handle(DeletePropertyRequest request, CancellationToken cancellationToken)
        {
            var propertyInDb = await _propertyRepo.GetByIdAsync(request.PropertyID);
            if (propertyInDb != null)
            {
                await _propertyRepo.DeleteAsync(propertyInDb);
                return true;
            }
            return false;
        }

        #endregion
    }
}
