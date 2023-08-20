

using projectt;
using System.Text.Json;

string savePath = @"C:\Users\rizo2\Downloads\Telegram Desktop\AllCountries (2).txt";

var jsonFile=File.ReadAllText(savePath);
var result=JsonSerializer.Deserialize<List<Country>>(jsonFile);
var filters = Console.ReadLine().Split(" ");
var person = new Person()
{
    Id = people.Last().Id + 1,
    Name = a,
    Age = b
};

people.Add(person);

var resultjson = JsonSerializer.Serialize(people);
File.WriteAllText(savePath, resultjson);
foreach (var item in people)
{
    Console.WriteLine($"Id={item.Id}\t Name{item.Name}\tAge{item}");
}
