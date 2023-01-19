using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_SingleOrDefault
{
    static void Main()
    {
        List<string> names = new List<string>() {
            "C#", "ASP.NET", "TypeScript"
        };

        // SingleOrDefault는 찾는 값을 반환, 없으면 null값 반환
        string csharp = names.SingleOrDefault(name => name == "C#");
        Console.WriteLine(csharp);

        string javascript = names.SingleOrDefault(n => n == "javascript");
        
        if (javascript == null) {
            Console.WriteLine("JavaScript 항목을 찾을 수 없습니다.");
        }
        Console.WriteLine(javascript);
    }
}
