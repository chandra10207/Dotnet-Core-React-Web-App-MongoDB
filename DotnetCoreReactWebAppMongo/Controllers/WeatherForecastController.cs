using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using MongoDB.Bson;
using DotnetCoreReactWebAppMongo.Models;

namespace DotnetCoreReactWebAppMongo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IMongoCollection<Shipwrecks> _shipwreckCollection;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IMongoClient client)
        {
            var database = client.GetDatabase("sample_geospatial");
            _shipwreckCollection = database.GetCollection<Shipwrecks>("shipwrecks");
        }


        [HttpGet]
        public IEnumerable<Shipwrecks> Get()
        {

            return _shipwreckCollection.Find(s => s.FeatureType == "Wrecks - Visible").ToList();
        }
    }

    internal interface IMongoCollection
    {
    }
}

