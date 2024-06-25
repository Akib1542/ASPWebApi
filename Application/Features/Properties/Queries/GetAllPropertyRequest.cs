using Application.Models;
using Domain;
using MediatR;

namespace Application.Features.Properties.Queries
{
    public class GetAllPropertyRequest : IRequest<List<PropertyDto>>
    {

    }
}
