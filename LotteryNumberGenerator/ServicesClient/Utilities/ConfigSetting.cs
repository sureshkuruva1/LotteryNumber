using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesClient.Utilities
{
    public static class ConfigSetting
    {
        public static string ServicesUrl = ConfigurationManager.AppSettings["APIServiceUrl"];
    }
}
