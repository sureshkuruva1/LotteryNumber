using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberGeneratorApi.Entities
{
    public class NumberGeneratorResponse
    {
        public NumberGeneratorResponse()
        {
            NumberSeries = new List<int>();
        }
        public List<int> NumberSeries { get; set; } 
    }
}