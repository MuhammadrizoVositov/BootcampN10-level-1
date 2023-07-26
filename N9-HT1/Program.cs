using System.Text.RegularExpressions;

var email=new LinkedList<string>();
email.AddLast("example@gmail.com");
email.AddLast("suv@gmail.com");
email.AddLast("fanta@gmail.com");
email.AddLast("cocacola@gmail.com");
email.AddLast("pepsi@gmail.com");
string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
var first=email.First;
while (first != null)
{
    if (Regex.IsMatch(first.Value,regex))
    {
        Console.WriteLine($"{first.Value} is valid");
    }
    else
    {
        Console.WriteLine($"{first.Value} is not valid");
    }    
    first = first.Next;
}

