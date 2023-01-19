// LINQ(Language INtegrated Query)
using System;
using System.Collections.Generic;
using System.Linq;


class LINQ_FromWhereSelect
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        // from은 데이터를 하나 가져옴
        var evenNumbers =
            from num in arr
            where num % 2 == 0
            select num;
        foreach (var number in evenNumbers)
        {
            Console.WriteLine($"짝수: {number}");
        }
    }
}

