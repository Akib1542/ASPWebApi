using Application.Repositories;
using Domain;
using MediatR;

namespace Application.Features.Images.Commands
{
    public class DeleteImageRequestHandler : IRequestHandler<DeleteImageRequest, bool>
    {
        #region Fields

        private readonly IImageRepo _imageRepo;

        #endregion

        #region CTOR

        public DeleteImageRequestHandler(IImageRepo imageRepo)
        {
            _imageRepo = imageRepo;
        }

        #endregion

        #region Fields

        public async Task<bool> Handle(DeleteImageRequest request, CancellationToken cancellationToken)
        {
            Image imageInDb = await _imageRepo.GetByIdAsync(request.ImageId);
            if (imageInDb != null)
            {
                //Delete
                await _imageRepo.DeleteAsync(imageInDb);
                return true;
            }
            return false;
        }

        #endregion

    }
}
