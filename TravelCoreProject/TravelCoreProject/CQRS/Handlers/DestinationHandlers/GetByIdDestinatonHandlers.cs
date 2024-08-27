using DataAccessLayer.Concreate;
using TravelCoreProject.CQRS.Queries.DestinatonQueries;
using TravelCoreProject.CQRS.Result.DestinationResult;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetByIdDestinatonHandlers
    {
        private readonly Context _context;

        public GetByIdDestinatonHandlers(Context context)
        {
            _context = context;
        }

        public GetByIDDestinatonQueriesResult Handler(GetByIdDestinatonQueries p)
        {
            var value = _context.Destinations.Find(p.ID);

            return new GetByIDDestinatonQueriesResult()
            {
                ID=value.DestinationId,
                City = value.DestinationCity,
                DayAndNight=value.DestinationDayAndNight
            };


        }




    }
}
