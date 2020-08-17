using Lab27_Day53.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Lab27_Day53.Services
{
    public class ApiWeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public ApiWeatherService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Weather> Get()
        {
            var current = await _client.GetFromJsonAsync<ApiWeatherGetCurrent>("MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=json");
            return current.CurrentObservation;
        }
        //public async Task<Weather> GetTime()
        //{   
        //    var time = await _client.GetFromJsonAsync<ApiGetTime>("MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=json");
        //    return time.Time;
        //}
        public class ApiWeatherGetCurrent
        {
            public Weather CurrentObservation { get; set; }
        }

        //public class ApiGetTime
        //{
        //    public Weather Time { get; set; }
        //}
            
    }
}
