// 쉬프트 연산자
using System;

class ShiftOperator
{
    static void Main()
    {
        Console.WriteLine("C# 시프트 연산자");
        int num = 2;
        Console.WriteLine(num << 2);
        // 16 8 4 2 1
        //  0 0 0 1 0
        //  0 1 0 0 0

        num = 40;
        Console.WriteLine(num >> 2);
        // 64 32 16 8 4 2 1
        //  0  1  0 1 0 0 0
        //  0  0  0 1 0 1 0

        // 다른 방법
        byte x = 0b0000_0010; // 2
        Console.WriteLine($"x : {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x}");
        Console.WriteLine($"x - x << 1 : {Convert.ToString(x << 1, 2).PadLeft(8, '0')} -> {x << 1}");
        Console.WriteLine($"x - x >> 1 : {Convert.ToString(x >> 1, 2).PadLeft(8, '0')} -> {x >> 1}");

    }
}