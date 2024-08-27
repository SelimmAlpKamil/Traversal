namespace TravelCoreProject.CQRS.Commands.DestinatonCommand
{
    public class UpdateDestinationCommand
    {

        public int Id { get; set; }
        public string City { get; set; }
        public string DayAndNight { get; set; }
    }
}
