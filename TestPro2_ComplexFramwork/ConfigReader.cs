using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

namespace TestPro2_ComplexFramwork.Utilities
{
    public class ConfigReader
    {
        private static dynamic _config;
        static ConfigReader()
        {
            var json = File.ReadAllText("resources/appsetting.json");
            _config = JsonConvert.DeserializeObject(json);
        }
        public static string GetBrowser()
        {
            return _config.driver;
        }
        public static string GetUrl()
        {
            return _config.url;
        }
    }
}
