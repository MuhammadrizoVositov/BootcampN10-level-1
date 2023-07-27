
//var heros = new GamingEngine();
//heros.dislay();
//Console.WriteLine();
//var newHeros = new OptimizeGameEngine();
//newHeros.dislay();


//class OptimizeGameEngine:GamingEngine
//{
//    public OptimizeGameEngine()
//    {
//        base.list.Add(new Hero { Name="Invoker",Id=Guid.NewGuid()});
//        base.list.Add(new Hero { Name = "Lina", Id = Guid.NewGuid() });
//        base.list.Add(new Hero { Name = "Medusa", Id = Guid.NewGuid() });
//    }
//}



//class GamingEngine
//{
//    public List <Hero> list;
//    public GamingEngine()
//    {
//        this.list = new List<Hero>(); 
//        this.list.Add(new Hero { Name = "Yunero", Id = Guid.NewGuid() });
//        this.list.Add(new Hero { Name = "Sven", Id = Guid.NewGuid() });
//        this.list.Add(new Hero { Name = "Tiny", Id = Guid.NewGuid() });
//    }
//    public void dislay()
//    {
//        foreach (var item in list)
//        {
//            Console.WriteLine(item);
//        }
//    }

//}


//class Hero
//{
//    public Guid Id { get; set; }
//    public string Name { get; set; }

//    public Hero(string name)
//    {
//        Id = Guid.NewGuid();
//        Name = name;
//    }

//    public override string ToString()
//    {
//        return $"{Name}  {Id}";
//    }
//}

//using System.ComponentModel.DataAnnotations;
//var events = new EventManeger();

//events.Add("Navroz", new DateTime(2023, 03, 21));
//events.Add("Vatan himoyachilar kuni", new DateTime(2023, 01, 14));
//events.Add("Hazil", new DateTime(2023, 04, 01));
//events.display();

//events.Add("Mustaqillik", new TimeOnly(12, 09, 01));
//events.Add("Kanistitutsiya", new TimeOnly(21, 12, 08));
//events.Add("Ustozlar kuni", new TimeOnly(20, 10, 01));
//events.NewDisplay();
//class EventManeger
//{
//    public Dictionary<string, DateTime> Events = new Dictionary<string, DateTime>();
//    public Dictionary<string, TimeOnly> dayEvents = new Dictionary<string, TimeOnly>();

//    public void Add(string name, DateTime date)
//    {
//        Events[name] = date;
//    }
//    public void Add(string name, TimeOnly time)
//    {
//        dayEvents[name] = time;
//    }
//    public void display()
//    {
//        foreach (var item in Events)
//        {
//            Console.WriteLine($"{item.Key} {item.Value}");
//        }
//    }
//    public void NewDisplay()
//    {
//        foreach (var item in dayEvents)
//        {
//            Console.WriteLine($"{item.Key} {item.Value}");
//        }
//    };


