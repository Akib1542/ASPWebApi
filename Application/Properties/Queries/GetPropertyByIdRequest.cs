using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Properties.Queries
{
    public class GetPropertyByIdRequest : IRequest<Property>
    {
        public int PropertyId { get; set; }
        public GetPropertyByIdRequest(int propertyId)
        {
            PropertyId = propertyId;    
        }
    }
}
