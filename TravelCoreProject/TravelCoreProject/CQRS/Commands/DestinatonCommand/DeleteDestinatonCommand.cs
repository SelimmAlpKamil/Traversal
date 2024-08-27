namespace TravelCoreProject.CQRS.Commands.DestinatonCommand
{
    public class DeleteDestinatonCommand
    {
        public DeleteDestinatonCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
