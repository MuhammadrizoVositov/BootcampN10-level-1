// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

var evenTime = new DateTime[10]
{
    new DateTime(2023,01,14),
    new DateTime(2023,02,14),
    new DateTime(2023,03,01),
    new DateTime(2023,03,21),
    new DateTime(2023,04,01),
    new DateTime(2023,05,09),
    new DateTime(2023,08,31),
    new DateTime(2023,10,01),
    new DateTime(2023,12,08),
    new DateTime(2023,012,18),
};
var eventDay = new string[10]
{
    "Vatan himoyachilari kuni",
    "Sevishganlar kuni",
    "Bahor bayrami",
    "Hazil kuni",
    "Xotira kuni",
    "Mustaqillik kuni",
    "Oqtuvchilar kuni",
    "Kanstitutsiya kuni",
    "Kuchuklar kuni",
    "Binasalar kuni",
};
var again = true;
while (again)
{
    Console.WriteLine("\t\t Main menu");
    Console.WriteLine("1-Nomi boyicha saralash ");
    Console.WriteLine("2-Vaqti boyicha saralash");
    Console.WriteLine("3-Nomi boyicha topish");
    Console.WriteLine("4-Vaqti boyicha topish\n");
    var MainMenu=Console.ReadKey().KeyChar;
    Console.WriteLine();
    Console.Clear();
    while (MainMenu == '1') 
    {
        
            Console.WriteLine("You pressed wrong button\n Please try again");
            MainMenu=Console.ReadKey().KeyChar;
            Console.WriteLine();
        
    }
    switch(MainMenu)
    {
        case '1':
            Console.Clear() ;
            Console.WriteLine("1-Event boyicha saralash:");
            Console.WriteLine("2-Eventni kuni boyicha saralash:");
            Console.WriteLine("Your choise:");
            var seconBtn=Console.ReadKey().KeyChar;
            Console.WriteLine();
            while (MainMenu == '1'&& seconBtn=='2')
            {
                Console.WriteLine("You have press wrong button\n Please try again");
                seconBtn=Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.Clear();
            switch(seconBtn)
            {
                case'1':
                    Console.WriteLine("1-Event nomi osish boyicha saralash:");
                    Console.WriteLine("2-Event nomi kamayish boyicha saralash:");
                    Console.WriteLine("Your choise:");
                    var thirdBtn = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    while (thirdBtn != '1' && thirdBtn != '2')
                    {
                        Console.WriteLine("You have press wrong button\n Please try again");
                        seconBtn = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                    }
                    Console.Clear();
                    switch (thirdBtn)
                    {
                        case'1':
                            orderBynameIncreasing(eventDay, evenTime);
                            Console.WriteLine("\t\t\tAfter sorting by name by incrasing order ");
                            display(eventDay, evenTime);
                                break;
                        case '2':
                            orderBynameDecreasing(eventDay, evenTime);
                            Console.WriteLine("\t\t\tAfter sorting by name by decrasing order ");
                            display(eventDay, evenTime);
                            break;
                    }
                    break;
                case '2':
                    Console.WriteLine("1-Event nomi osish boyicha saralash:");
                    Console.WriteLine("2-Event nomi kamayish boyicha saralash:");
                    Console.WriteLine("Your choise:");
                    var fourBtn = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    while (fourBtn != '1' && fourBtn != '2')
                    {
                        Console.WriteLine("You have press wrong button\n Please try again");
                        seconBtn = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                    }
                    Console.Clear();
                switch (fourBtn)
                    {
                    case'1':
                    orderBynameDecreasing(eventDay, evenTime);
                    Console.WriteLine("\t\t\tAfter sorting by name by increasing order ");
                    display(eventDay, evenTime);
                    break;
                        case '2':
                            Console.WriteLine("\t\tAfter sorting event by date by decreasing order");
                            orderBydateDecreasing(eventDay, evenTime);
                            display(eventDay, evenTime);
                            break;​
                    }
                    break;
            }
            break;
        case '2':
            Console.Clear();
            Console.Write("We are gona find your event by name.\nPlease enter events name: ");
            var name = Console.ReadLine();
            var isIndex = -1;
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (eventDay[i].Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    isIndex = i;
                }
            }
            if (isIndex > 0)
                Console.WriteLine($"The event you want is -- {eventDay[isIndex]} " +
                    $"\nIt's date {evenTime[isIndex].ToString("dd.MM.yyyy")} and it's index is {isIndex}");
            else
                Console.WriteLine("There is no such event");
            break;
        case '3':
            Console.Clear();
            Console.Write("We are gonna find event by date\nPlease enter events date you want (Sample: yyyy.mm.dd): ");
            var fulldate = Console.ReadLine().Split('.');
            var userDate = new DateTime(Convert.ToInt32(fulldate[0]), Convert.ToInt32(fulldate[1]), Convert.ToInt32(fulldate[2]));
            isIndex = -1;
            for (int i = 0; i < 10; i++)
            {
                if (evenTime[i] == userDate)
                {
                    isIndex = i;
                }
            }
            if (isIndex > 0) Console.WriteLine($"The event you want is -- {eventDay[isIndex]}\nIt's date - {evenTime[isIndex]} and it's index {isIndex}");​
            break;
        case '4':
            break;
        case '5':
            again = false;
            break;
    }
    Console.Clear();
    Console.WriteLine("\t\tThank you using");



}
static void orderBynameIncreasing(string[] events, DateTime[] eventsDate)
{
    for (int i = 0; i < events.Length - 1; i++)
    {
        for (int j = i + 1; j < events.Length; j++)
        {
            if (events[i].CompareTo(events[j]) < 0)
            {
                var name = events[i];
                events[i] = events[j];
                events[j] = name;
                var date = eventsDate[i];
                eventsDate[i] = eventsDate[j];
                eventsDate[j] = date;​
            }
        }
    }
}
static void orderBynameDecreasing(string[] events, DateTime[] eventsDate)
{
    for (int i = 0; i < events.Length - 1; i++)
    {
        for (int j = i + 1; j < events.Length; j++)
        {
            if (events[i].CompareTo(events[j]) > 0)
            {
                var name = events[i];
                events[i] = events[j];
                events[j] = name;
                var date = eventsDate[i];
                eventsDate[i] = eventsDate[j];
                eventsDate[j] = date;​
            }
        }
    }
}
static void orderBydateIncreasing(string[] events, DateTime[] eventsDate)
{
    for (int i = 0; i < events.Length - 1; i++)
    {
        for (int j = i + 1; j < events.Length; j++)
        {
            if (eventsDate[i].DayOfYear > eventsDate[j].DayOfYear)
            {
                var name = events[i];
                events[i] = events[j];
                events[j] = name;
                var date = eventsDate[i];
                eventsDate[i] = eventsDate[j];
                eventsDate[j] = date;​
            }
        }
    }
}
static void orderBydateDecreasing(string[] events, DateTime[] eventsDate)
{
    for (int i = 0; i < events.Length - 1; i++)
    {
        for (int j = i + 1; j < events.Length; j++)
        {
            if (eventsDate[i].DayOfYear < eventsDate[j].DayOfYear)
            {
                var name = events[i];
                events[i] = events[j];
                events[j] = name;
                var date = eventsDate[i];
                eventsDate[i] = eventsDate[j];
                eventsDate[j] = date;​
            }
        }
    }
}
static void display(string[] events, DateTime[] eventsDate)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Event: {events[i]} ----->> Date: {eventsDate[i].ToString("dd.MM.yyy")}");
    }
}
    






