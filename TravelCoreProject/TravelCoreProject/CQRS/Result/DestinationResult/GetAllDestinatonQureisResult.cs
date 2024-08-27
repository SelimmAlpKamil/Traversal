using System.Reflection;

namespace TravelCoreProject.CQRS.Result.DestinationResult
{
    public class GetAllDestinatonQureisResult
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string DayAndNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
