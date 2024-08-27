using DataAccessLayer.Concreate;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Queries.GuideQueries;
using TravelCoreProject.CQRS.Result.GuideResult;

namespace TravelCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetByIdGuestHandlers : IRequestHandler<GetByIdGuideQueries, GetByIdGuideResult>
    {
        private readonly Context _context;

        public GetByIdGuestHandlers(Context context)
        {
            this._context = context;
        }

        public async Task<GetByIdGuideResult> Handle(GetByIdGuideQueries request, CancellationToken cancellationToken)
        {
            var value = await _context.Guides.FindAsync(request.GuideID);

            return new GetByIdGuideResult()
            {
                GuideName = value.GuideName,
                GuideDescripton = value.GuideDescripton,
                GuideImage = value.GuideImage,
                GuideInstagramURL = value.GuideInstagramURL,
                GuideXURL = value.GuideXURL,
                GuideStatus = true

            };

        }
    }
}
