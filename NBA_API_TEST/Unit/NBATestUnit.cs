using NUnit.Framework;
using RestSharp;

namespace NBA_API_TEST.Unit
{
    public class NBATestUnit
    {
    }
    //smoke
    [TestFixture]
    public class SmokeBadAPIConnection
    {
        string? baseURL;

        [SetUp]
        public void SetUp()
        {
            baseURL = "https://api-nba-v1.p.rapidapi.com/games?season=2021&h2h=1-2";
        }

        [Test]
        public void UnsuccesfulLogin()
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-key", "FailKey");
            request.AddHeader("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
        }
    }

    [TestFixture]
    public class SmokeGoodAPIConnection
    {
        string? baseURL;

        [SetUp]
        public void SetUp()
        {
            baseURL = "https://api-nba-v1.p.rapidapi.com/games?season=2021&h2h=1-2";
        }

        [Test]
        public void SuccesfulLogin()
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-key", "0bc50516e8msh6a510fc2b729d03p194455jsn5ebebdca214a");
            request.AddHeader("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
        }
    }


    [TestFixture]
    public class BadAPIConnection
    {
        string? baseURL;

        [SetUp]
        public void SetUp()
        {
            baseURL = "https://api-nba-v1.p.rapidapi.com/games?season=2021&h2h=1-2";
        }

        [Test]
        public void UnsuccesfulLogin()
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-key", "FailKey");
            request.AddHeader("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            Assert.IsTrue(!response.IsSuccessful);
        }
    }

    [TestFixture]
    public class GoodAPIConnection
    {
        string? baseURL;

        [SetUp]
        public void SetUp()
        {
            baseURL = "https://api-nba-v1.p.rapidapi.com/games?season=2021&h2h=1-2";
        }

        [Test]
        public void SuccesfulLogin()
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-key", "0bc50516e8msh6a510fc2b729d03p194455jsn5ebebdca214a");
            request.AddHeader("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            Assert.IsTrue(response.IsSuccessful);



        }

    }








}
