using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Where
{
    static void Main()
    {
        List<string> names = new List<string> { "Angular", "Bootstrap", "C#" };

        // Contains는 해당 되는지 체크
        // Where에서 IEnumerable<T>을 반환 값을 가지는데, List<T>랑 성질이 비슷함
        IEnumerable<string> search = names.Where(n => n.Contains("a"));

        foreach (var name in search)
        {
            Console.WriteLine("찾은 결과: " + name);
        }

        int[] arr = { 1, 2, 3, 4, 5 };

        var q = arr.Where(num => num % 2 == 1);

        foreach (var n in q)
        {
            Console.WriteLine(n);
        }
    }

}

