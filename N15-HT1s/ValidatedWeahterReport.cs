using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1s
{
    internal class ValidatedWeahterReport : WeatherReport
    {
        private List<WeatherReport> WeathetReports = new List<WeatherReport>();
        public ValidatedWeahterReport(DateTime day, string ob_havo)
            : base(day, ob_havo)
        {


        }

        public override void Add(DateTime day, string ob_havo)
        {
            WeatherReport newReport = new WeatherReport(day, ob_havo);

            bool isDuplicate = WeathetReports.Contains(newReport);

            if (isDuplicate)
            {
                WeathetReports.Add(newReport);
            }
        }
    }
}
