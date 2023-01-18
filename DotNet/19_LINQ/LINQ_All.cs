// All() 확장 메서드: 시퀀스의 모든 요소가 조건을 만족 하는지 여부 결정
using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_All
{
    static void Main()
    {
        bool[] complete = { true, true, true };

        Console.WriteLine(complete.All(c => c == true));
    }

}

