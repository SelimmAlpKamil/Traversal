using System;

namespace SignalRApi.DAL
{
    public enum Ecity
    {
        IStanbul = 1,
        Ankara = 2,
        Bursa = 3,
        Antalya = 4

    }


    public class Visitor
    {

        public int VisitorID { get; set; }
        public Ecity CityVisitor { get; set; }
        public int CityVisitorCount { get; set; }
        public DateTime VisitorDate { get; set; }






    }
}
