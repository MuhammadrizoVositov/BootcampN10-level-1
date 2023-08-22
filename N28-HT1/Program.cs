
using N28_HT1;

var evenTstack = new EventStack<IEvent>();
evenTstack.Push(new Event("Mustaqillik", new DateTime(2023, 9, 1)));
Console.WriteLine(evenTstack);

public interface IEvent
{
     Guid Id { get; set; }
     string Name { get; set; }
     DateTime Date { get; set; }
}

