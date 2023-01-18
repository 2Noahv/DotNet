// 반복문

using System;

class forDemo
{
    static void Main()
    {
       // for (초기식; 조건식; 증감식) {}
       // for ( ; ; ) {}  무한루프 됨

        for (var i = 0; i < 3; i++) {
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("Count : " + i);
        }

        var n = 3;
        var sum = 0;
        for (var i = 1; i <= n; i++) {
            sum = sum + i; // sum += i;
        }
        Console.WriteLine($"1부터 3까지의 합: {sum}");
        
        // 삼각형 만들기
        for (int i = 1; i <= 5 ; i++) {
            for (int j = 1; j <= i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // 팩토리얼 값을 출력하는 프로그램
        int fact = 0;

        for (int i = 1; i < 4; i++) {
            Console.Write($"{i}! -> ");
            fact = 1; // 1로 초기화
            for (int j = 1; j <= i; j++) {
                fact = fact * j;
            }
            Console.WriteLine($"{fact,2}");
        }
    }
}

      