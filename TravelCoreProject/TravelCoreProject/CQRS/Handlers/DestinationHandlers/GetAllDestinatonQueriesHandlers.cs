using DataAccessLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TravelCoreProject.CQRS.Result.DestinationResult;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinatonQueriesHandlers
    {
        private readonly Context _context;

        public GetAllDestinatonQueriesHandlers(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinatonQureisResult> Handler()
        {
            var values = _context.Destinations.Select(x=> new GetAllDestinatonQureisResult
            {
                ID = x.DestinationId,
                City = x.DestinationCity,
                DayAndNight = x.DestinationDayAndNight,
                Capacity = x.DestinationCapacity,
                Price= x.DestinationPrice,

            }).AsNoTracking().ToList();

            return values;
        }


    }
}
