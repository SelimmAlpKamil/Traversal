using MediatR;

namespace TravelCoreProject.CQRS.Commands.GuideCommand
{
    public class CreateGuideCommand:IRequest
    {
        public int GuideID { get; set; }

        public string GuideName { get; set; }

        public string GuideImage { get; set; }

        public string GuideDescripton { get; set; }

        public string GuideInstagramURL { get; set; }

        public string GuideXURL { get; set; }

        public bool GuideStatus { get; set; }
    }
}
