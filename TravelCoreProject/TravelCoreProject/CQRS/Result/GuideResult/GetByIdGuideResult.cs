namespace TravelCoreProject.CQRS.Result.GuideResult
{
    public class GetByIdGuideResult
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
