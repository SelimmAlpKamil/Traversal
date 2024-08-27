using MediatR;
using System.Collections.Generic;
using TravelCoreProject.CQRS.Result.GuideResult;

namespace TravelCoreProject.CQRS.Queries.GuideQueries
{
    public class GetByIdGuideQueries:IRequest<GetByIdGuideResult>
    {
        public GetByIdGuideQueries(int guideID)
        {
            GuideID = guideID;
        }

        public int GuideID { get; set; }

    }
}
