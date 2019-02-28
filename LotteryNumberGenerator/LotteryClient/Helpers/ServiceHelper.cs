using LotteryClient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicesClient;

namespace LotteryClient.Helpers
{
    public static class ServiceHelper
    {
        public static NumberSeriesResponse GenerateNumbers(NumberSeriesRequest request)
        {
            var response = new NumberSeriesResponse();
            var client = new ServicesHttpClient<NumberSeriesRequest, NumberSeriesResponse>();
            return client.GetAsync(string.Format("/api/Generator/series?length={0}&min={1}&max={2}", request.SeriesLength,request.NumberMin,request.NumberMax));
        }
    }
}