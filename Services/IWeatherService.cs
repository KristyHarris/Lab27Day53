using Lab27_Day53.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27_Day53.Services
{
    public interface IWeatherService
    {
        Task<Weather> Get();
        
    }
}
