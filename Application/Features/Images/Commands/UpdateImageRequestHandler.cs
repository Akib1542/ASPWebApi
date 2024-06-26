using Application.Repositories;
using Domain;
using MediatR;

namespace Application.Features.Images.Commands
{
    public class UpdateImageRequestHandler : IRequestHandler<UpdateImageRequest, bool>
    {
        #region Fields

        private readonly IImageRepo _imageRepo;

        #endregion

        #region CTOR

        public UpdateImageRequestHandler(IImageRepo imageRepo)
        {
            _imageRepo = imageRepo;
        }

        #endregion

        #region Methods

        public async Task<bool> Handle(UpdateImageRequest request, CancellationToken cancellationToken)
        {
            Image imageInDb = await _imageRepo.GetByIdAsync(request.UpdateImage.Id);
            if (imageInDb != null)
            {
                //update
                imageInDb.Name = request.UpdateImage.Name;
                imageInDb.Path = request.UpdateImage.Path;
                await _imageRepo.UpdateAsync(imageInDb);
                return true;
            }
            return false;
        }

        #endregion
    }
}
