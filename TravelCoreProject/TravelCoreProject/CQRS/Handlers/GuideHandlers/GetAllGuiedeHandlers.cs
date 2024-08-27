using DataAccessLayer.Concreate;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Queries.GuestQueries;
using TravelCoreProject.CQRS.Result.GuestResult;

namespace TravelCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuiedeHandlers : IRequestHandler<GetAllGuideQueries, List<GetAllGuideResult>>
    {
        private readonly Context _context;

        public GetAllGuiedeHandlers(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideResult>> Handle(GetAllGuideQueries request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideResult
            {
                GuideID = x.GuideID,
                GuideName = x.GuideName,
                GuideDescripton = x.GuideDescripton,
                GuideImage = x.GuideImage,
                GuideInstagramURL = x.GuideInstagramURL,
                GuideStatus = true,
                GuideXURL = x.GuideXURL
            }).AsNoTracking().ToListAsync();

            
        }



    }
}
