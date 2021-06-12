using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIClient.Models;

namespace WebAPIClient.Services
{
    public interface IVSFlyServices
    {
        public Task<IEnumerable<FlightM>> GetFligths();
    }
}
