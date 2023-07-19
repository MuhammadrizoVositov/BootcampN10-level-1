var birthdates = new DateTime[4];


birthdates[0] = new DateTime(2023, 12, 7);
birthdates[1] = new DateTime(2023, 11, 22);
birthdates[2] = new DateTime(2023, 06, 03);
birthdates[3] = new DateTime(2023, 02, 06);
var name = new string[4];

name[0] = "Gayrat";
name[1] = "Azam";
name[2] = "John";
name[3] = "G'aybulla";

var temp = birthdates[0];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (birthdates[i].DayOfYear < birthdates[j].DayOfYear)
        {
            temp = birthdates[i];
            birthdates[i] = birthdates[j];
            birthdates[j] = temp;
            var ism = name[i];
            name[i] = name[j];
            name[j] = ism;

        }
    }
}
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"{name[i]} was born {birthdates[i]}");
}