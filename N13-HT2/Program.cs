using System.Text;

var passwordLength = default(int);
var hasLetters = default(bool);
var hasDigits = default(int);

Console.Write("How many length your password should have: ");
passwordLength = int.Parse(Console.ReadLine());
Console.Write("SHould your password contains any letter (y/n): ");
hasLetters = Console.ReadLine().ToUpper() == "Y";

var userPassword = new PasswordGenerate(passwordLength, hasLetters);

Console.WriteLine($"Simple password: {userPassword.Generate()}\n");


Console.Write("How many length your password should have: ");
passwordLength = int.Parse(Console.ReadLine());
Console.Write("SHould your password contains any letter (y/n): ");
hasLetters = Console.ReadLine().ToUpper() == "Y";
Console.Write("SHould your password contains any symbol (y/n): ");
var hasSymbols = Console.ReadLine().ToUpper() == "Y";
var securePassword = new SecurePasswordGenerator(passwordLength, hasLetters);
Console.WriteLine($"Secure password: {securePassword.Generate(hasSymbols)}");


class SecurePasswordGenerator : PasswordGenerate
{
    public SecurePasswordGenerator(int length, bool hasLetters, bool hasDigits = true)
        : base(length, hasLetters, hasDigits)
    { }
    public StringBuilder Generate(bool hasSymbol)
    {
        var ran = new Random();
        while (password.Length < length)
        {
            var belgi = ran.Next(0, 4);
            if (belgi == 0 && hasLetters)
            {
                password.Append((char)ran.Next(65, 90));
            }
            else if (belgi == 1 && hasDigits)
            {
                password.Append((char)ran.Next(48, 58));
            }
            else if (belgi == 2 && hasSymbol)
            {
                password.Append((char)ran.Next(32, 48));
            }
            else if (belgi == 3 && hasLetters)
            {
                password.Append((char)ran.Next(97, 123));
            }
        }
        return password;
    }
}

class PasswordGenerate
{
    public int length;
    public bool hasLetters;
    public bool hasDigits;
    public StringBuilder password = new StringBuilder();
    public PasswordGenerate(int length, bool hasLetters, bool hasDigits = true)
    {
        this.length = length;
        this.hasLetters = hasLetters;
        this.hasDigits = hasDigits;
    }
    public StringBuilder Generate()
    {
        var ran = new Random();
        while (password.Length < length)
        {
            var belgi = ran.Next(0, 3);
            if (belgi == 0 && hasLetters)
            {
                password.Append((char)ran.Next(65, 90));
            }
            else if (belgi == 1 && hasDigits)
            {
                password.Append((char)ran.Next(48, 58));
            }
            else if (belgi == 2 && hasLetters)
            {
                password.Append((char)ran.Next(67, 123));
            }
        }
        return password;

    }
}
