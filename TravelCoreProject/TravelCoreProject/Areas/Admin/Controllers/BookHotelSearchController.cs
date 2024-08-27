using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using TravelCoreProject.Areas.Admin.Models;
using System.Collections.Generic;
using MailKit.Search;
using System.Linq;

namespace TravelCoreProject.Areas.Admin.Controllers
{

    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class BookHotelSearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(string CityName)
        {
            

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={CityName}&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "1f372022ecmsh929dcda3f00f487p1a4977jsn13d42d39ea71" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var jsonData = JsonConvert.DeserializeObject<List<BookHotelSearchViewModel.Class1>>(body);

                foreach(var x in jsonData)
                {
                    TempData["CityName"] = x.city_ufi;
                }

                return RedirectToAction("Index", "BookHotel", new { area = "Admin" });

            }



            

        }






    }
}

