using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_OrderBy
{
    static void Main()
    {
        List<string> names = new List<string>() { "C#", "Bootstrap", "Angular" };

        // 알파벳 순서대로 정렬
        var orders = names.OrderBy(name => name);

        foreach (var name in orders)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();


        // 알파벳 순서의 역순 정렬
        var orders2 = names.OrderByDescending(name => name);

        foreach (var name in orders2)
        {
            Console.WriteLine(name);
        }

    }

}

