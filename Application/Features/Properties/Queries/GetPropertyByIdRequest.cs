using Application.Models;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Properties.Queries
{
    public class GetPropertyByIdRequest : IRequest<PropertyDto>
    {
        #region Fields

        public int PropertyId { get; set; }

        #endregion

        #region CTOR

        public GetPropertyByIdRequest(int propertyId)
        {
            PropertyId = propertyId;
        }

        #endregion
    }
}
