using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using TravelCoreProject.Areas.Admin.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace TravelCoreProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    [AllowAnonymous]
    public class BookExchangeApiController : Controller
    {

        public async Task<IActionResult> Index()
        {
            
            List<BookExchangeApiViewModel> bookExchangeApiViewModels = new List<BookExchangeApiViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-us&currency=TRY"),
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
             
                var value = JsonConvert.DeserializeObject<BookExchangeApiViewModel>(body);  

                return View(value.exchange_rates);
            }
        }
    }
}
