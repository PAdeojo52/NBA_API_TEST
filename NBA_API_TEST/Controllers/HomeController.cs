using Microsoft.AspNetCore.Mvc;
using NBA_API_TEST.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Diagnostics;
using System.Text.Json;

namespace NBA_API_TEST.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        string baseURL = "https://api-nba-v1.p.rapidapi.com/games?season=2021&h2h=1-2";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //Call API and pop data in view

            List<NBAModel> nbaModels = new List<NBAModel>();
            var client = new RestClient(baseURL);

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-key", "0bc50516e8msh6a510fc2b729d03p194455jsn5ebebdca214a");
            request.AddHeader("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);


            if (response.IsSuccessful)
            {

                string results = client.Execute(request).Content;


                nbaModels = JObject.Parse(results)["response"].ToObject<List<NBAModel>>();

                var serilizationClass = new NBASerilizationClass();

                foreach (NBAModel nmodel in nbaModels)
                {
                    NBASerilizatioPayload NPL = new NBASerilizatioPayload();
                    NPL.HomeTeam = nmodel.Teams.Home.Code;
                    NPL.AwayTeam = nmodel.Teams.Visitors.Code;
                    NPL.HomePoints = nmodel.Scores.Home.Points;
                    NPL.AwayPoints = nmodel.Scores.Visitors.Points;
                    NPL.GetDate.Start = nmodel.Date.Start;
                    NPL.GetDate.End = nmodel.Date.End;
                    serilizationClass.con.payload.Add(NPL);

                }

                string fileName = "NBAOutput.json";
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(serilizationClass, options);
                System.IO.File.WriteAllText(fileName, jsonString);

                Console.WriteLine(jsonString);

            }
            Console.WriteLine(response.Content);

            ViewData.Model = nbaModels;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}