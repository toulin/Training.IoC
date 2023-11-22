using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//需額外參考 System.Configuration.dll
namespace MySample.ConfigManager
{
    public class AppSettings
    {
        public string Setting1 { get; set; }
        public int Setting2 { get; set; }

        public static AppSettings LoadFromConfig()
        {
            return new AppSettings
            {
                Setting1 = ConfigurationManager.AppSettings["Setting1"],
                Setting2 = int.Parse(ConfigurationManager.AppSettings["Setting2"])
            };
        }
    }
}
