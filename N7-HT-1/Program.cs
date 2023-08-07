var date = new DateTime(2023, 7, 12);
var sleepDay = new DateTime[]
{
    date.AddDays(1),
    date.AddDays(2),
    date.AddDays(3),
    date.AddDays(4),
    date.AddDays(5),
};
var sleepHour = new TimeSpan[]
{
    TimeSpan.FromHours(7),
    TimeSpan.FromHours(9),
    TimeSpan.FromHours(10),
    TimeSpan.FromHours(8),
    TimeSpan.FromHours(6)
};
var sleepInteruption = new int[]
{
    3,
    4,
    10,
    0,
    5
};
Console.WriteLine("1 - kunlarni yaqinligi bo'yicha kamayib borish tartibida saralash\n" +
    "2 - Ekranga kun uyqu davomiyligi va sifatini chiqarish");
var btn = Console.ReadKey().KeyChar;
Console.WriteLine();
switch (btn)
{
    case '1':
        sort(sleepDay);
        break;
    case '2':
        var awakeHours = 0;
        for (int i = 0; i < 5; i++)
        {
            int awakenTime = sleepInteruption[i] / sleepHour[i].Hours;
            Console.WriteLine($"{sleepDay[i].ToString("dd.MM.yyyy")} - {sleepHour[i].Hours} hours - {(sleepHour[i].Hours - awakenTime) * 1.0 / (8 - awakeHours) * 10}");
            if (sleepHour[i].Hours - awakenTime < 8)
            {
                awakeHours += (8 - (sleepHour[i].Hours - awakenTime));
            }
        }
        break;
}

static void sort(DateTime[] daysInsleep)
{
    for (int i = 0; i < daysInsleep.Length; i++)
    {
        for (int j = i + 1; j < daysInsleep.Length; j++)
        {
            if (daysInsleep[j].DayOfYear > daysInsleep[i].DayOfYear)
            {
                var day = daysInsleep[i];
                daysInsleep[i] = daysInsleep[j];
                daysInsleep[j] = day;
            }
        }
    }
    foreach (var day in daysInsleep)
    {
        Console.WriteLine(day.ToString("dd.MM.yyyy"));
    }
}