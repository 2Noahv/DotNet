// 반복문

using System;

class whileDemo
{
    static void Main()
    {
        var result = "";

        var count = 0; //[1] 초기식
        while (count < 3) { //[2] 조건식
            result += "Hello\n"; //[!] 실행문
            count++; //[3] 증감식
        }

        // 짝수의 합 구하기
        var sum = 0;

        var i = 1;
        while (i <= 100) { 
            if (i % 2 == 0) {
                sum += i; 
            }
            i++;    
        }
        Console.WriteLine($"짝수의 합: {sum}"); 


    }
}