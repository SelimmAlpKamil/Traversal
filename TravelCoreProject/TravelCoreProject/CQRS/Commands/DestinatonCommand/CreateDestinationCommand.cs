using EntityLayer.Concreate;
using System.ComponentModel.DataAnnotations;

namespace TravelCoreProject.CQRS.Commands.DestinatonCommand
{
    public class CreateDestinationCommand
    {

        public string DestinationCity { get; set; }

        public string DestinationDayAndNight { get; set; }

        public bool DestinationStatus { get; set; }

        public double DestinationPrice { get; set; }

        public int DestinationCapacity { get; set; }

    }

}
