// 제어문(선택문: Selection/Decision)
// 블록(Block): scope 이해
using System;

class switchDemo
{
    static void Main()
    {
        var score = 1;
        switch(score)
        {
            case 1:
                Console.WriteLine("score 1");
                break;
            case 2:
                Console.WriteLine("score 2");
                break;
        }

        score = 2;
        switch (score)
        {
            case 1:
                Console.WriteLine("score 1");
                break;
            case 2:
                Console.WriteLine("score 2");
                break;
        }

        Console.WriteLine("정수를 입력하세요.");
        int answer = Convert.ToInt32(Console.ReadLine()); 
        
        // 선택문
        switch(answer)
        {
            case 1:
                Console.WriteLine("1을 선택했습니다.");
                break;
            case 2:
                Console.WriteLine("2을 선택했습니다.");
                break;
            case 3:
                Console.WriteLine("3을 선택했습니다.");
                break;
            default:
                Console.WriteLine("그냥 찍으셨군요.");
                break;
        }
    }
}

      