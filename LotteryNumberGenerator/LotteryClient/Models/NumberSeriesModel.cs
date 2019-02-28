using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LotteryClient.Models
{
    public class NumberSeriesModel
    {
        public NumberSeriesModel()
        {
            LotteryNumbers = new List<int>();
        }

        public int SeriesLength { get; set; }

        public int NumberMin { get; set; }

        public int NumberMax { get; set; }

        public List<int> LotteryNumbers { get; set; }

        public string[] NumbersClass { get; set; }
    }
}