// 제어문(선택문: Selection/Decision)
// 블록(Block): scope 이해
using System;

class ifDemo
{
    static void Main()
    {
        int score = 80;

        if (score >= 90) {
            Console.WriteLine("A");
        }
        else if (score >= 80)        {
            Console.WriteLine("B");
        }
        else if (score >= 70)        {
            Console.WriteLine("C");
        }
        else if (score >= 60)        {
            Console.WriteLine("D");
        }
        else {
            Console.WriteLine("F");
        }       
    }
}



