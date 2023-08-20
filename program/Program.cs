




using program;
using System.Text.Json;

List<Person> persons = new List<Person>()
{
    new Person{Id=1, Name="Begzod", Age=18},
    new Person{Id=2, Name="Bobirjon", Age=20}

};
string path = @"C:\Users\rizo2\Downloads\Telegram Desktop\AllCountries.txt";
string jsonPerson=JsonSerializer.Serialize(persons);

//using (StreamWriter writer = new StreamWriter(path)) 
//{
//    writer.Write(jsonPerson);
//}
using (StreamReader reader = new StreamReader(path))
{
    var people = JsonSerializer.Deserialize<List<Person>>(reader.ReadToEnd());
    foreach (var item in people)
    {
        Console.WriteLine(item.Name);
    }
}



