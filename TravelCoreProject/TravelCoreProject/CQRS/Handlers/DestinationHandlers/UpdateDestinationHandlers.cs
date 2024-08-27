using DataAccessLayer.Concreate;
using TravelCoreProject.CQRS.Commands.DestinatonCommand;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationHandlers
    {
        private readonly Context _context;

        public UpdateDestinationHandlers(Context context)
        {
            _context = context;
        }

      

        public void Handler(UpdateDestinationCommand command)
        {
            var findDestination = _context.Destinations.Find(command.Id);

            findDestination.DestinationCity = command.City;
            findDestination.DestinationDayAndNight = command.DayAndNight;

            _context.SaveChanges();

        }


    }
}
