using System.Runtime.CompilerServices;

var user = new String[]
{
     "Inception",
    "Dark Knight",
    "Top Gun 2",
    "Don't Look Up",
    "Top Gun"

};
Console.WriteLine("\t\tOsish taribi");
for (int indexA = 0; indexA < user.Length; indexA++)
{
    for(int indexB = indexA;indexB < user.Length;indexB++)
    {
        if (user[indexA].CompareTo(user[indexB]) == 1 )
        {
            var num = user[indexA];
            user[indexA] = user[indexB];
            user[indexB] = num;
        }

    }
    
}
for(int indexA = 0; indexA<user.Length; indexA++)
{
    Console.WriteLine(user[indexA]);
}

Console.WriteLine("\t\tKamayish taribi");
for (int indexA = 0; indexA < user.Length; indexA++)
{
    for (int indexB = indexA; indexB < user.Length; indexB++)
    {
        if (user[indexA].CompareTo(user[indexB]) == -1)
        {
            var num = user[indexA];
            user[indexA] = user[indexB];
            user[indexB] = num;
        }

    }

}
for (int indexA = 0; indexA < user.Length; indexA++)
{
    Console.WriteLine(user[indexA]);
}