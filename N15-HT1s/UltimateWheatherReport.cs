using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1s
{
    internal class UltimateWheatherReport
    {



    
        public class UltimateWeatherReport : ValidatedWeahterReport
        {
            SortedDictionary<DateTime, string> weather = new SortedDictionary<DateTime, string>();
            public SortedDictionary<DateTime, string> Get(DateTime date, int days)
            {
                foreach (var day in Weather)
                {
                    if (weather.Count == days)
                        break;
                    if (day.Key.DayOfYear >= date.DayOfYear)
                        weather[day.Key] = day.Value;

                }
                return weather.Count == 0 ? Get() : weather;
            }
            public SortedDictionary<DateTime, string> Get()
            {
                return new SortedDictionary<DateTime, string>();
            }
            public SortedDictionary<DateTime, string> Get(int days)
            {
                foreach (var day in Weather)
                {
                    if (weather.Count == days)
                        break;
                    if (day.Key.DayOfYear >= DateTime.Now.DayOfYear)
                        weather[day.Key] = day.Value;

                }
                return weather.Count == 0 ? Get() : weather;
            }
        }
    }
}

