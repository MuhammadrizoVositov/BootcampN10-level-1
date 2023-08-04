
using static N15_HT1s.UltimateWheatherReport;

//var weather = new WeatherReport();
//weather.Add(new DateTime(2023, 12, 1), "Quyoshli");
//weather.Add(DateTime.Now, "Quyoshli");
//Console.WriteLine(weather.Get(new DateTime(2023,12,1)));
//Console.WriteLine(weather.Get(DateTime.Now.AddDays(1)));

var ultimate = new UltimateWeatherReport();
ultimate.Add(new DateTime(2023, 10, 1), "Quyoshli");
ultimate.Add(new DateTime(2023, 1, 1), "Qor");
ultimate.Add(new DateTime(2023, 1, 1), "Sovuq havo");
ultimate.Add(new DateTime(2023, 5, 1), "Bulutli");
ultimate.Add(new DateTime(2023, 10, 2), "Yomg'ir");
var toplam = ultimate.Get(new DateTime(2023, 11, 1), 3);
var toplamB = ultimate.Get(3);
if (toplamB.Count == 0)
    Console.WriteLine("Uzr, to'liq ma'lumot yo'q");
foreach (var item in toplamB)
{
    Console.WriteLine(item);
}

Console.WriteLine("______________________________");
if (toplam.Count == 0)
    Console.WriteLine("Uzr, to'liq ma'lumot yo'q");
foreach (var item in toplam)
{
    Console.WriteLine(item);
}



