using NumberGeneratorApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberGeneratorApi.Models
{
    public class NumberGeneratorRepository : INumberGeneratorRepository
    {
        public NumberGeneratorResponse Generate(NumberGeneratorRequest request)
        {
            var lResponse = new NumberGeneratorResponse();
            Random rnd = new Random();
            int curNumber; 
            for(int i=0;i < request.SeriesLength;i++)
            {
                curNumber = rnd.Next(request.NumberMin, request.NumberMax);
                if (!lResponse.NumberSeries.Contains(curNumber))
                {
                    lResponse.NumberSeries.Add(curNumber);
                    if(lResponse.NumberSeries.Count == request.SeriesLength)
                    {
                        break;
                    }
                }
                else
                {
                    i--;
                    continue;
                }
            }
            
            return lResponse;
        }
    }
}