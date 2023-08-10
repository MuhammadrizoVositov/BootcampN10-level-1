using System.Text.RegularExpressions;



var valid = new Validator();
Console.WriteLine("Iltimos yoshingizni kiriting:");
var age=int.Parse(Console.ReadLine());
Console.WriteLine("Iltmos ismingizni kiriting:");
var firstName=Console.ReadLine();
Console.WriteLine("Iltimos Famiyangizni kiriting: ");
var lastName=Console.ReadLine();
Console.WriteLine("Iltimos emailingizni kiritng: ");
var email=Console.ReadLine();
Console.WriteLine("Iltimos  Telfon raqamingizni kiriting :");
var phoneNumber=Console.ReadLine();

Console.WriteLine(valid.IsValidAge(age)?"Kiritligan yosh to'gri":"Kiritilgan yosh noto'g'ri");// ifni kichiraytirilgani

Console.WriteLine(valid.IsValidFirstName(firstName) ? "Kiritilgan ism tog'ri" : "Kiritilgan ism noto'g'ri");

Console.WriteLine(valid.IsValidLastName(lastName) ? "Kiritilgan ism" : "Kiritilgan noto'g'ri");

Console.WriteLine(valid.IsValidEmail(email) ? "Kiritilgan email to'gri" : "Kiritilgan email noto'g'ri");

Console.WriteLine(valid.IsValidPhoneNumber(phoneNumber) ? "Kiritilgan nomer to'gri" : "Kiritilgan nomer noto'g'ri");


//if(valid.IsValidEmail(email) )
//{
//    Console.WriteLine("email togri");
//}
//else
//{
//    Console.WriteLine("Email notog'ri")
//};



class Validator

{
    public bool IsValidAge(int age)
    {
        if(age > 12 && age<80)
        { 
            return true;
        }
        return false;

    }
    
    public bool IsValidFirstName(string firstName)
    {
        if(firstName.Length!=0 && firstName.All(char.IsLetter))
        {
            return true;
        }
        return false;
    }
    public bool IsValidLastName(string lastName) 
    {
        if (lastName.Length != 0 && lastName.All(char.IsLetter))// Ismni tekshirish 
        {
            return true;
        }
        return false;
    }
    public bool IsValidEmail(string email) // Emailni tekshirish
    {
        if (Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
        {
            return true;
        }
        return false;
    }
    public bool IsValidPhoneNumber(string phoneNumber) 
    {
        if (phoneNumber.Length != 0 && phoneNumber.All(char.IsDigit))// Raqamga tekshirish
        {
            return true;
        }
        return false;
    }


}
