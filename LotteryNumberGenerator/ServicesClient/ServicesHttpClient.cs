using ExceptionLogger;
using ServicesClient.Entities;
using ServicesClient.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ServicesClient
{
    public class ServicesHttpClient<I, R>
    {
        HttpClient client;
        JavaScriptSerializer jsonserializer;

        public ServicesHttpClient()
        {
            jsonserializer = new JavaScriptSerializer();
            client = new HttpClient();
            client.Timeout = new TimeSpan(0, 5, 20);
            client.BaseAddress = new Uri(ConfigSetting.ServicesUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public R GetAsync(string paramUrl)
        {
            var response = client.GetAsync(paramUrl).Result;

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    string msg = response.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(msg))
                    {
                        return jsonserializer.Deserialize<R>(msg);
                    }
                    else
                    {
                        throw new BusinessException("ErrGet01", "Empty response retuned from service");
                    }
                }
                else
                {
                    string msg = response.Content.ReadAsStringAsync().Result;
                    var responseBody = jsonserializer.Deserialize<BusinessExceptionSerializeType>(msg);
                    throw new BusinessException(responseBody.Code, responseBody.Message);
                }
            }
            catch (Exception ex)
            {
                throw new BusinessException("ErrGet02", ex.Message,ex);
            }            
        }
    }
}
