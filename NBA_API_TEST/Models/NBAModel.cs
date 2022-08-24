using Newtonsoft.Json;

namespace NBA_API_TEST.Models
{
    public class NBAModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("season")]
        public long Season { get; set; }

        [JsonProperty("date")]
        public Date Date { get; set; }

        [JsonProperty("stage")]
        public long Stage { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("periods")]
        public Periods Periods { get; set; }

        [JsonProperty("arena")]
        public Arena Arena { get; set; }

        [JsonProperty("teams")]
        public Teams Teams { get; set; }

        [JsonProperty("scores")]
        public Scores Scores { get; set; }

        [JsonProperty("officials")]
        public object[] Officials { get; set; }

        [JsonProperty("timesTied")]
        public object TimesTied { get; set; }

        [JsonProperty("leadChanges")]
        public object LeadChanges { get; set; }

        [JsonProperty("nugget")]
        public object Nugget { get; set; }
    }

    public partial class Arena
    {
        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("state")]
        public object State { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }
    }

    public partial class Date
    {
        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("end")]
        public object End { get; set; }

        [JsonProperty("duration")]
        public object Duration { get; set; }
    }

    public partial class Periods
    {
        [JsonProperty("current")]
        public long Current { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("endOfPeriod")]
        public object EndOfPeriod { get; set; }
    }

    public partial class Scores
    {
        [JsonProperty("visitors")]
        public ScoresHome Visitors { get; set; }

        [JsonProperty("home")]
        public ScoresHome Home { get; set; }
    }

    public partial class ScoresHome
    {
        [JsonProperty("win")]
        public object Win { get; set; }

        [JsonProperty("loss")]
        public object Loss { get; set; }

        [JsonProperty("series")]
        public Series Series { get; set; }

        [JsonProperty("linescore")]
        public object[] Linescore { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }
    }

    public partial class Series
    {
        [JsonProperty("win")]
        public object Win { get; set; }

        [JsonProperty("loss")]
        public object Loss { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("clock")]
        public object Clock { get; set; }

        [JsonProperty("halftime")]
        public object Halftime { get; set; }

        [JsonProperty("short")]
        public long Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }
    }

    public partial class Teams
    {
        [JsonProperty("visitors")]
        public TeamsHome Visitors { get; set; }

        [JsonProperty("home")]
        public TeamsHome Home { get; set; }
    }

    public partial class TeamsHome
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("get")]
        public string Get { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }

        [JsonProperty("errors")]
        public List<object> Errors { get; set; }

        [JsonProperty("results")]
        public long Results { get; set; }

        [JsonProperty("response")]
        public List<NBAModel> Response { get; set; }
    }

    public partial class Parameters
    {
        [JsonProperty("season")]

        public long Season { get; set; }

        [JsonProperty("h2h")]
        public string H2H { get; set; }
    }

}
