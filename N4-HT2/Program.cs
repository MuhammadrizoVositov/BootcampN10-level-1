// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iltimos ismingizni kiriting:");
var fullname = Console.ReadLine().Split();
var user = "qwertyuioplkjhgfdsazxcvbnm_________1234567890";
Random random = new Random();
var name = fullname[0];
var usres = "abdulla gayrat gulbarno nozima bobir botir";
if (usres.Contains(name))
{
    while (name.Length < 13)
    {
        name += user[random.Next(0, user.Length)].ToString();

    }
}
Console.WriteLine(name);
