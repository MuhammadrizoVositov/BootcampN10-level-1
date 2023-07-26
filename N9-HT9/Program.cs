// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

var eventName = new string[]
{
"FrontSpot About new Angular features",
"AWS Tashkent - Develop your ML Project with Amazon SageMaker",
"GDG - Google IO Extended",
"MDC - Sharpist hackathon ",
"WoW 2.0 - Let's talk about Caching",
};
var eventDate = new DateTime[]
{
    new DateTime(2023,08,10,9,0,0),
    new DateTime(2023,08,10,9,0,0),
    new DateTime(2023,08,10,9,0,0),
    new DateTime(2023,08,10,9,0,0),
    new DateTime(2023,08,10,9,0,0),

};
var uz = "dd.mm.yyyy hh:mm";
var ru = "dd.mm.yyyy  hh:mm";
var en = "dd:mm:yyyy hh:mm ttt";
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{eventName}\t\t\t{eventDate}");
}

while (true)
{
    Console.WriteLine("\n-uz\n-ru\n-en\n");
    Console.Write("You can choose:");
    var button = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch(button)
    {
        case '1':
            Console.Clear();
            Display(eventDate, eventName, uz);
            Console.WriteLine("\n");
            break;
        case '2':
            Console.Clear();
            Display(eventDate, eventName, uz);
            Console.WriteLine("\n");
            break;
        case '3':
            Console.Clear();
            Display(eventDate, eventName, uz);
            Console.WriteLine("\n");
            break;
    }
}
static void Display(DateTime[] eventDate, string[] eventName, string format)
{


for (int i = 0; i < eventName.Length; i++)
{
    for(int j = 0; j < eventDate.Length; j++)
    {
        if (eventDate[i].DayOfYear == eventDate[j].DayOfYear)
        {
            var days = eventDate[i];
            eventDate[i] = eventName[j];
            eventDate[j]= days;
            var num = eventDate[i];
            eventDate[i] = eventName[j];
            eventDate = num; 
        }
    }
}
}