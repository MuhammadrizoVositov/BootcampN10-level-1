
// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

int ball = 100;
string text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore," +
    " nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum." +
    " Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus," +
    " odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!\r\n";

string[] words = text.Split('.');
int textLengs = 0;
if (words.Length < 500)
{
    textLengs = 1;
}
int WordLengs = 0;
int number = 0;
for (int i = 0; i < words.Length; i++)
{
    int countWords = 0;
    if (words[i].Length > 20)
    { WordLengs = 1; }
    for (int j = 0; j < words.Length; j++)
    {

        if (words[i] == words[j])
        { countWords++; }
    }
    if (countWords * 100 / words.Length > 20)
    { number = 1; }
}

int isCapital = 0;
var santense = text.Split('.');
for (int i = 0; i < santense.Length; i++)
{
    for (int j = 0; j < santense[i].Length; j++)
    {
        var formatWord = santense[i][0].ToString().ToUpper() + santense[i].Substring(1);
        if (formatWord != words[i])
            isCapital = 1;
    }

}
var overall = 100 - textLengs * 5 - number * 5 - isCapital * 10 - WordLengs * 20;
Console.WriteLine(overall);
