



using Projectsampl;
using System.Linq;
using System.Text.Json;



string studentPath = @"D:\temp";
var student = JsonSerializer.Deserialize<List<Student>>
(File.ReadAllText(studentPath));
Console.WriteLine(1);



string locationPath = @"D:\temp";
var location= JsonSerializer.Deserialize<List<Location>>
(File.ReadAllText(locationPath));


string specialitsPath = @"D:\temp";
var specialyts= JsonSerializer.Deserialize<List<Specially>>
(File.ReadAllText(specialitsPath));

var studentGroup = specialyts.GroupJoin(
    student,
    specialyts => specialyts.id,
    student => student.id);


var locate=location.Where()









