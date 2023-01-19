using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Map
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, };

        // 다른 언어의 Map 기능이 Select 기능임
        // Select() 확장 메서드를 사용하여 새로운 형태로 가공
        var nums = numbers.Select(it => it * it);

        foreach (var num in nums) 
        {
        Console.WriteLine(num);
        }
    }
}

