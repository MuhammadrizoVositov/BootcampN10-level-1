using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1s
{
    internal class WeatherReport
    {
        protected Dictionary<DateTime, string> report = new Dictionary<DateTime, string>();

        private readonly DateTime day;
        private readonly string ob_havo;
        public WeatherReport(DateTime day, string ob_havo)
        {
            this.day = day;
            this.ob_havo = ob_havo;
        }

        public string Get(DateTime day)// shu type deyiladi
        {
            return Find(day); //
        }
        private string Find(DateTime day)//
        {
            return report.ContainsKey(day) ? report[day] : "Bunday kun mavjud emas";//Keylarini tekshirish shu
        }
        public virtual void Add(DateTime day, string ob_havo)
        {
            report.Add(day, ob_havo);
        }
    }
}
