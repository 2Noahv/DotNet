// 비트 연산자
using System;

class BitOperator
{
    static void Main()
    {
        byte x = 0b0011;
        byte y = 0b0010;

        Console.WriteLine($"{x & y}");
        // 비트 곱(And): 둘 다 1일 때 1반환
        //   0011
        // & 0010

        Console.WriteLine($"{x | y}");
        // 비트 합(Or): 둘 중 하나만 1일 때 1반환
        //   0011
        // | 0010

        Console.WriteLine($"{~x}");
        // 비트 반전(Not): 0은 1로 1인 0으로 비트 반전
        //   0011
        // ~ 1100  최상위 비트가 1이므로 - 인식

        Console.WriteLine($"{x ^ y}");
        // 서컴플렉스 기호, Xor: 서로 다를 때 참(1) 반환
        //   0011
        // ^ 0010


        // 다른 방법
        int a = Convert.ToInt32("1010", 2); // 10
        int b = Convert.ToInt32("0110", 2); // 6

        int and = a & b;
        Console.WriteLine($"{and} : {Convert.ToString(and, 2)}"); // 2, 0010

        int or = a | b;
        Console.WriteLine($"{or} : {Convert.ToString(or, 2)}"); // 14, 1110

        int xor = a ^ b;
        Console.WriteLine($"{xor} : {Convert.ToString(xor, 2)}"); // 12, 1100

        int not = ~a;
        Console.WriteLine($"{not} : {Convert.ToString(not, 2)}"); 
        // -11, 11111111111111111111111111110101 (32bit의 부호비트 때문에)

    }
}