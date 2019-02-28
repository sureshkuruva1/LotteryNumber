using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotteryClient.Entities
{
    public class NumberSeriesResponse
    {
        public NumberSeriesResponse()
        {
            NumberSeries = new List<int>();
        }
        public List<int> NumberSeries { get; set; }
    }
}