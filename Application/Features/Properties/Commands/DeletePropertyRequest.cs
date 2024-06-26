using MediatR;

namespace Application.Features.Properties.Commands
{
    public class DeletePropertyRequest : IRequest<bool>
    {
        #region Fields

        public int PropertyID { get; set; }

        #endregion

        #region CTOR

        public DeletePropertyRequest(int property)
        {
            PropertyID = property;
        }

        #endregion
    }
}
