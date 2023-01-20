using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Single
{
    static void Main()
    {
        List<string> colors = new List<string> { "Red", "Green", "Blue" };

        // Single은 찾는 값는 값을 반환, 없으면 예외 발생
        string red = colors.Single(c => c == "Red");

        Console.WriteLine(red);

        try
        {
            // 없는 데이터 요청시 예외 발생
            string balck = colors.Single(color => color == "Black");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
}
