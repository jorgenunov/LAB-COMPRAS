using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeira.Models
{
    public class WeatherApiResponse
    {
        public APILocation Location { get; set; }
        public APICurrent Current { get; set; }
        

        public class APILocation
        {
            public string Name { get; set; }
            public string Region { get; set; }
            public string Country { get; set; }
            public double Lat { get; set; }
            public double Lon { get; set; }
            public string Tz_id { get; set; }
            public int Localtime_epoch { get; set; }
            public DateTime Locatime { get; set; }
        }

        public class APICurrent
        {
            public double Temp_c { get; set; }
            public APICurrentCondition Condition {get;set;}
        
            public class APICurrentCondition
           {
            public string Text { get; set; }
            public string Icon { get; set; }
           }

        }
    }
}
