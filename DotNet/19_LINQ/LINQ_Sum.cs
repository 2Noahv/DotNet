// LINQ: C# 언어에 직접 쿼리(Query) 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름
using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Sum
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine(numbers.Count());
        Console.WriteLine(numbers.Average());

        // 람다 식에서 람다 연산자 =>(Goes to)은 
        // 왼쪽의 입력 매개 변수를 오른쪽의 람다 본문과 구분한다.
        numbers.Where(n => n % 2 == 0);
     

        // 식 람다
        numbers.Select(x => x);

        // 문 람다
        numbers.Select(x => { return x; });


        List<string> techs = new List<string>();
        techs.Add("C# ");
        techs.Add("ASP.NET ");
        techs.Add("Blazor ");
        
        foreach (var ttechs in techs)
        {
            Console.WriteLine(ttechs);
        }
        Console.WriteLine();

        // 오름차순 정렬
        var test = techs.OrderBy(t => t);
        foreach (var ttecjs in test)
        {
            Console.WriteLine(ttecjs);
        }
        Console.WriteLine();

        // 내림차순 정렬
        var test2 = techs.OrderByDescending(t => t);
        foreach (var ttecjs in test2)
        {
            Console.WriteLine(ttecjs);
        }
    }

}

