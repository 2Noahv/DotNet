using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Chaining
{
    static void Main()
    {
        List<string> names = new List<string> { "C#", "Bootstrap", "Angular" };

        // 체이닝: 확장 메서드를 여러 개 사용
        var results = 
            names
                .Where(name => name.Length > 2)
                .OrderBy(n => n);
            
        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
    }
}
