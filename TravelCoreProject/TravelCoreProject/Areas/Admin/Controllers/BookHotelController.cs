using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{


    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class BookHotelController : Controller
    {
        public async Task<IActionResult> Index(string cityID)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/search?checkout_date=2024-09-15&order_by=popularity&filter_by_currency=AED&include_adjacency=true&children_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&room_number=1&dest_id={TempData["CityName"]}&dest_type=city&adults_number=2&page_number=0&checkin_date=2024-09-14&locale=en-gb&units=metric&children_ages=5%2C0"),
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
                
                var value= JsonConvert.DeserializeObject<BookHotelViewModel>(body); 

                return View(value.result);
            }
        }
    }
}
