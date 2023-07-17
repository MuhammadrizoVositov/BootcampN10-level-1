int yig = 0;
var test = new string[]
{
    "1- Test\n 5*5 jabobi ?",
    "2- Test\n 6*6 jabobi ?",
    "3- Test\n 7*7 jabobi ?",
    "4- Test\n 8*8 jabobi ?",
    "5- Test\n 9*9 jabobi ?"
};
var ToJav = new string[]
    {
        "A)25",
        "A)36",
        "A)49",
        "A)64",
        "A)81",
    };
var NoJav = new string[]
    {
        "B)32",
        "B)50",
        "B)97",
        "B)12",
        "B)44",
    };
var UserAnswer = new string[5];
for (int i = 0; i < test.Length; i++)
{
    Console.WriteLine(test[i]);
    Console.WriteLine(ToJav[i]);
    Console.WriteLine(NoJav[i]);
    Console.WriteLine("Javobni tanlang:");
    var ozg = Console.ReadLine();
    UserAnswer[i] = ozg;
};
for (int i = 0;i < test.Length;i++)
{

    if (UserAnswer[i] == ToJav[i][0].ToString())
    {
        Console.WriteLine("Correct ");
        Console.WriteLine("Ball: 5");
        yig += 5;
    }
    else
    {
        Console.WriteLine("Wrong answer");
        Console.WriteLine("Balls: 0");
    }
}
Console.WriteLine("Your total mark is {0}", yig);






