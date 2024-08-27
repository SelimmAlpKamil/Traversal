using MediatR;
using System.Collections.Generic;
using TravelCoreProject.CQRS.Result.GuestResult;

namespace TravelCoreProject.CQRS.Queries.GuestQueries
{
    public class GetAllGuideQueries:IRequest<List<GetAllGuideResult>>
    {
    }
}
