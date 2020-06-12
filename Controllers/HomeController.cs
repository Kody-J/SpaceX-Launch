using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpaceX_Launch.Models;
using Newtonsoft.Json.Linq;

namespace SpaceX_Launch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var launchDetails = await GetLaunchJSon();
            ViewBag.launchDetails = launchDetails;
            return View();
        }

        private static async Task<List<LaunchDetail>> GetLaunchJSon()
        {
            var requestUri = new Uri("https://api.spacexdata.com/v3/launches");
            var httpClient = new HttpClient();

            var launchDetails = new List<LaunchDetail>();
            var responseJsonArray = new JArray();
            var payLoads = new List<int>();

            try
            {
                var response = await httpClient.GetAsync(requestUri);

                if (response.IsSuccessStatusCode)
                {
                    responseJsonArray = response.Content.ReadAsAsync<JArray>().Result;

                    for (var index = 0; index < responseJsonArray.Count; index++)
                    {
                        //Date Parsing for sorting, coverting to CST, and seperting time
                        var launchDetail = new LaunchDetail();
                        var stringDateTime = responseJsonArray[index]["launch_date_utc"].ToString();

                        //Convert JToken.Date to System.DateTime
                        var launchUtcDateTime = DateTime.Parse(stringDateTime);
                        var cst = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
                        var launchCstDateTime = TimeZoneInfo.ConvertTimeFromUtc(launchUtcDateTime, cst);
                        var launchDateTime = launchCstDateTime.ToString();
                        var dateThenTime = launchDateTime.Split(' ');
                        launchDetail.LaunchDate = dateThenTime[0];
                        launchDetail.LaunchTime = dateThenTime[1] + " " + dateThenTime[2];

                        //Split the dates and convert to Int32 for Sorting by date desc
                        var seperateDate = dateThenTime[0].Split('/');
                        launchDetail.DateForSort = ((Convert.ToInt32(seperateDate[2])*10000) + (Convert.ToInt32(seperateDate[0])*100) + Convert.ToInt32(seperateDate[1]));
                       
                        launchDetail.RocketName = responseJsonArray[index]["rocket"]["rocket_name"].ToString();

                        if (responseJsonArray[index]["launch_success"].Type != JTokenType.Null)
                            launchDetail.LaunchStatus = responseJsonArray[index]["launch_success"].ToString();

                        //Checks if payload was preasent
                        if (responseJsonArray[index]["rocket"]["second_stage"]["payloads"][0]["payload_mass_kg"].Type != JTokenType.Null)
                        {
                            payLoads.Add(Convert.ToInt32(responseJsonArray[index]["rocket"]["second_stage"]["payloads"][0]["payload_mass_kg"]));
                            launchDetail.PayloadMass = payLoads.Last();
                        }
                        launchDetails.Add(launchDetail);
                    }

                    payLoads.Sort();
                    payLoads.Reverse();
                    //Sort Payloads in a seperate List and then reverse list
                    //Iterate over reverse sorted payload list and reterive the LaunchDetail obj with matching payload and use index to express rank
                    for (var index = 0; index < payLoads.Count; index++)
                    {
                        for (var detailIndex = 0; detailIndex < launchDetails.Count; detailIndex++)
                        {
                            if (payLoads[index] == launchDetails[detailIndex].PayloadMass && launchDetails[detailIndex].PayloadRank == 0)
                            {
                                launchDetails[detailIndex].PayloadRank = index + 1;
                            }
                        }
                    }
                    //Sort launchDetails List by their date int value
                    launchDetails.Sort((x, y) => x.DateForSort.CompareTo(y.DateForSort));
                }
                else
                {
                    throw new Exception("Invalid URI");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return launchDetails;
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
