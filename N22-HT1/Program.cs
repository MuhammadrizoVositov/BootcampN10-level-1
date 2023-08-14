

var a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 ,9,10,11,12,123,14,121,109};
a.Where(item=>IsPrime(item)).OrderDescending().ToList().ForEach(Console.WriteLine);

static bool IsPrime(int number)
{
    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return number > 1;
}













