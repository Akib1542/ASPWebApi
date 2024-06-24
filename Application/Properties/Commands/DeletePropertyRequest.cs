﻿using Domain;
using MediatR;

namespace Application.Properties.Commands
{
    public class DeletePropertyRequest : IRequest<bool>
    {
        public int PropertyID { get; set; }
        public DeletePropertyRequest(int property)
        {
            PropertyID = property;
        }
    }
}
