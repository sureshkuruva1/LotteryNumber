using NumberGeneratorApi.Entities;
using NumberGeneratorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NumberGeneratorApi.Controllers
{
    public class GeneratorController : ApiController
    {
        private INumberGeneratorRepository _repository;

        public GeneratorController() { }
        public GeneratorController(INumberGeneratorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public NumberGeneratorResponse GetSeries(int length,int min,int max)
        {
            var request = new NumberGeneratorRequest
            {
                SeriesLength = length,
                NumberMin = min,
                NumberMax = max
            };
            return _repository.Generate(request);
        }
    }
}
