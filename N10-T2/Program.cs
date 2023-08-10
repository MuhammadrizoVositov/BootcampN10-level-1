using System.ComponentModel.Design;
using System.Reflection.Metadata;




var generate =new  PasswordGenerator();

Console.WriteLine(generate.Generator);













public class PasswordGenerator
{
    private  string _password;

    public const int Digits = 95884871;
    public const string Letters = "QWERTYUIOPLKJHGFDSAZXCVBNMmnbvcxzasdfghjklpoiuytrewq";
    public const string Symbols = "!@#$%^&*()-_=+[]{}|;:,.<>?";
    int lengh;
    private readonly Random random = new Random();
    public string Generator(int hasDigit,string hasLetters,string hasSymbols,int lenghs)
    {
        Console.WriteLine("Nechta son qatnashsin:");
        bool hasDigits = Console.ReadLine().ToLower() =="y";

        Console.WriteLine("Nechta Harf qatnashsin:");
        bool hasLetter = Console.ReadLine().ToLower()=="h";

        Console.WriteLine("Nechta belgi qatnashsin:");
        bool hasSymbol = Console.ReadLine().ToLower()=="k";

        Console.WriteLine("Uzunligi qancha bolsin");
        int lengh=Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < lengh;)
        {
            if (hasLetter)
            {
                _password += (char)random.Next(65, 92);//Casting qilish
                i++;
            }
            if(hasDigits)
            {
                _password += (int)random.Next(48, 59);
                i++;
            }
            if(hasSymbol)
            {
                _password += (char)random.Next(32, 48);
                i++;
            }

        }

        return _password;

    }

}
