using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_Project_NET.Helper
{
    public class Helper
    {
        public string GetConfigurationData(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }
    }
}