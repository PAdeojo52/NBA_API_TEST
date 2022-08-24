namespace NBA_API_TEST.Models
{
    public class NBASerilizationClass
    {

        public string Version { get; set; }

        public int status { get; set; }

        public NBASerilizationContent con = new NBASerilizationContent();
        public List<NBASerilizationContent> Content { get; set; }

        public NBASerilizationClass()
        {
            Content = new List<NBASerilizationContent>();
            Version = "0.0.1";
            status = 200;
            Content.Add(con);
        }

    }
    [Serializable]
    public class NBASerilizationContent
    {
        public string Sources { get; set; }


        public int Status { get; set; }

        public List<NBASerilizatioPayload> payload { get; set; }
        public NBASerilizationContent()
        {
            payload = new List<NBASerilizatioPayload>();

            Sources = "Goodr DB";
            Status = 200;
        }
    }

    public class NBASerilizatioPayload
    {
        public Date GetDate { get; set; }

        public string HomeTeam { get; set; }
        public long HomePoints { get; set; }
        public string AwayTeam { get; set; }
        public long AwayPoints { get; set; }

        public NBASerilizatioPayload()
        {
            GetDate = new Date();
            HomeTeam = "TEST";
            HomePoints = 0;
            AwayTeam = "TEST";
            AwayPoints = 0;

        }

    }
}
