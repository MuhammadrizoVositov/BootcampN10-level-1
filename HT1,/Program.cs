
Console.WriteLine("Iltimos ismingizni kiriting:");
var firstName=Console.ReadLine();
Console.WriteLine("Iltimos familyangizni kiriting:");
var Surname = Console.ReadLine();
Console.WriteLine("Iltimos Yoshingizni kiritng:");
var Age = Console.ReadLine();


var us = new User(firstName,Surname,Age);
Console.WriteLine(us.name);
Console.WriteLine(us.Surname);
Console.WriteLine(us.age);

public class User
{
    public string name;
    public string Surname;
    public int age;


    public User(string name, string Surname, int age)
    {
        this.name = name;
        this.Surname = Surname;
        this.age = age;
    }
}


















//public class User
//{
    
//    public string FirstName { get; set; }
//    public string SurName { get; set; }
//    public int Age { get; set; }


//}
