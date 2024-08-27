using DataAccessLayer.Concreate;
using DataAccessLayer.Migrations;
using EntityLayer.Concreate;
using TravelCoreProject.CQRS.Commands.DestinatonCommand;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationHandlers
    {
        private readonly Context _context;

        public CreateDestinationHandlers(Context context)
        {
            _context = context;
        }


        public void Handler(CreateDestinationCommand command)
        {

            _context.Destinations.Add(new Destination()
            {
                DestinationCity = command.DestinationCity,
                DestinationDayAndNight = command.DestinationDayAndNight,
                DestinationPrice = command.DestinationPrice,
                DestinationStatus = true,
                DestinationCapacity = command.DestinationCapacity,
                GuideID = 1,
                DestinationDescription = "test",
                DestinationDescriptionLong1 = "test",
                DestinationDescriptionLong2 = "test",
                DestinationImage = "test",
                DestinationImageCover = "test",
                DestinationImageDetail = "test",
                FeatureMainPost = false,
                FeatureSubPost = false,






            }); ;

            _context.SaveChanges();
        }

    }
}
