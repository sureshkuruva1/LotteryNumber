using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotteryClient.Entities
{
    public class NumberSeriesRequest
    {
        public int SeriesLength { get; set; }

        public int NumberMin { get; set; }

        public int NumberMax { get; set; }
    }
}