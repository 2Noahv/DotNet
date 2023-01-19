// 반복문

using System;

class forechDemo
{
    static void Main()
    {
        string[] names = { "C#", "ASP.NET" };
        foreach (string name in names) // name변수 선언 후 names 배열에서 하나씩 뽑아서 
        {
            Console.WriteLine(name); // 출력하는 의미
        }

        string str = "ABC123";
        foreach (char c in str) // 데이터가 있는 만큼 하나씩 뽑아서
        {
            Console.WriteLine(c); // 출력하는 의미
        }
    }
}