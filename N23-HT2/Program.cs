








using N23_HT2;

var user = new List<Users>()
{
    new Users("John", "Doe", "johndoe@example.com"),
    new Users("Jane", "Doe", "janedoe@example.com"),
    new Users("Bob", "Smith", "bobsmith@example.com"),
    new Users("Alice", "Johnson", "alicejohnson@example.com"),
    new Users("Mike", "Brown", "mikebrown@example.com"),
    new Users("Emily", "Davis", "emilydavis@example.com"),
    new Users("David", "Wilson", "davidwilson@example.com"),
    new Users("Sarah", "Taylor", "sarahtaylor@example.com"),
    new Users("Tom", "Anderson", "tomanderson@example.com"),
    new Users("Lisa", "Thomas", "lisathomas@example.com")
};
List<Users> users = user.Where(x => x.FirstName.ToLower().Contains("li")).ToList();
foreach(var name in users)
{
    Console.WriteLine(name.FirstName);
}

