// LINQ Any 확장 메서드: 시퀀스에 요소가 하나라도 있는지 확인
using System;
using System.Linq;

class LINQ_Any
{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };
        var bln = arr.Any(num => num == 2); // bool 값 변환
        if (bln)
        {
            Console.WriteLine("시퀀스에 조건에 맞는 요소가 있다.");
        }
    }

}

