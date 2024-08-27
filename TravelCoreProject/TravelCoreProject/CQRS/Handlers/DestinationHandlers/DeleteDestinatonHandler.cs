using DataAccessLayer.Concreate;
using Org.BouncyCastle.Asn1.BC;
using TravelCoreProject.CQRS.Commands.DestinatonCommand;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class DeleteDestinatonHandler
    {
        private readonly Context _context;

        public DeleteDestinatonHandler(Context context)
        {
            _context = context;
        }

        public void Handler(DeleteDestinatonCommand command) {
            var findDestinaton = _context.Destinations.Find(command.Id);

            _context.Destinations.Remove(findDestinaton);

            _context.SaveChanges();


        }


    }
}
