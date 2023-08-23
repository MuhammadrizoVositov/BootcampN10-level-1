
var Users = new List<string>
{
   "Bobirjon",
    "Ozodbek",
    "Firdavs",
};

var CareteFle = Users.Select(async user =>  await Task.Run(() =>
{
    var file =  File.Create($"{user.ToLower()}.docx");
    Console.WriteLine( $"{user}File yartildi" );
    return file;
}));
await Task.WhenAll(CareteFle);
