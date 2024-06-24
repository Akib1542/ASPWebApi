using Application.Models;
using Domain;
using MediatR;

namespace Application.Properties.Queries
{
    public class GetAllPropertyRequest : IRequest<List<Property>>
    {

    }
}
