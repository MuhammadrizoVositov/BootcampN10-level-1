var studentName = new string[]
{
    "Bobir",
    "Jamshid",
    "Odil",
    "Botir",
    "Bahodir",
    "Jamol",
    "Muodil",
    "Donyor",
    "Nodir",
    "Bekzod"
};
int[] score = new int[]
{
    90,
    100,
    70,
    60,
    80,
    50,
    40,
    20,
    30,
    10,
};
for (int i = 0; i < score.Length-1; i++)
{
    for (int j = i+1; j < score.Length; j++)
    {
       if (score[j] > score[i])
        {
            var MaxScore = score[i];
            score[i] = score[j];
            score[j] = MaxScore;
            var MxstudentName = studentName[i];
            studentName[i] = studentName[j];
            studentName[j] = MxstudentName;
        }
    }
}
Console.WriteLine($"The max score  {score.Max()}");
Console.WriteLine($"The Avarage score  {score.Average()}");
Console.WriteLine($"The Min score  {score.Min()}\n\n");
for (int i = 0;i < score.Length;i++)
{
    if (score[i] >=90)
    {
        Console.WriteLine($"{studentName[i]}The Top score is  {score[i]}");
    }
    else if (score[i] >=80)
    {
        Console.WriteLine($"{studentName[i]}The Avarage score is  {score[i]}");
    }
    else if (score[i] >=60)
    {
        Console.WriteLine($"{studentName[i]} The low score  {score[i]}");
    }
    else
    {
        Console.WriteLine($"{studentName[i]} Fail and mark  {score[i]}");
    }

}

