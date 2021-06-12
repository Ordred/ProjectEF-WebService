using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebAPIClient.Models;

namespace WebAPIClient.Services
{
    public class VSFlyServices : IVSFlyServices
    {
        private readonly HttpClient _client;
        private readonly string _baseURI;
        public VSFlyServices(HttpClient client)
        {
            _client = client;
            _baseURI = "https://localhost:44322/api/";
        }

        public async Task<IEnumerable<FlightM>> GetFligths()
        {
            var uri = _baseURI + "Flights";

            var responseString = await _client.GetStringAsync(uri);
            var flightsList = JsonConvert.DeserializeObject<IEnumerable<FlightM>>(responseString);
            return flightsList;

        }
    }
}
