using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Cast operator
        object[] objects = { 1, "2", 3.0, "4", 5 };
        //IEnumerable<int> integers = objects.Cast<int>();

        //foreach (int num in integers)
        //{
        //    Console.WriteLine(num);
        //}

        // OfType operator
        object[] mixedObjects = { 1, "2", 3.0, "4", 5 };
        IEnumerable<string> strings = mixedObjects.OfType<string>();

        foreach (string str in strings)
        {
            Console.WriteLine(str);
        }
    }
}
