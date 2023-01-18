// 할당(대입) 연산자 : 변수에 특정 값으로 초기화하면 자동 유추에 의해서 형식이 결정됨
// 연산자(Operator): 더하기(+), 빼기(-)와 같은 연산을 진행하는 키워드
// *(곱하기, /(나누기), %(나머지, 모듈러스)  
using System;

class Operator
{
    static void Main()
    {
        // 피연산자 num, 1234
        // 연산자 +
        var num = 1000;
        var number = num + 1234;

        // 단항 연산자(Unary Operator): +, -
        var value = 0;
        value = 8;
        Console.WriteLine(value);
        value = +value;
        Console.WriteLine(value);
        value = -value;
        Console.WriteLine(value);

        num = 123;
        number = 456;
        Console.WriteLine($"Hello, " + "World");
        Console.WriteLine($"123" + "456");
        Console.WriteLine($"{num + number}");
        Console.WriteLine($"123 + {number}");
        Console.WriteLine($"123" + true);

        int x = 1;
        int y = 1;

        x = x + 2; // 기본형
        y += 2; // 축약형
        Console.WriteLine($"x: {x}, y: {y}");

        x += y; // 누적: x변수에 y변수의 값을 누적
        Console.WriteLine($"x += y: {x}");

        x -= y; // 가강: x에서 y를 뺀 후 다시 x에 할당
        Console.WriteLine($"x -= y: {x}");

        // 증감 연산자: 정수 자료형 변수의 값을 1증가
        int numt1 = 5;
        // numt1 = numt1 + 1;
        // numt1 += 1;

        // 전위(PreFix) 증감 연사자 : 우선 순위가 높음
        ++numt1;
        Console.WriteLine($"{numt1}");
        // 후위(NextFix) 증감 연사자 : 우선 순위가 낮음
        numt1++;
        Console.WriteLine($"{numt1}");

        // 감소 연산자: 정수 자료형 변수의 값을 1감소
        int numt2 = 5;
        // numt2 = numt2 - 1;
        // numt2 -= 1;
        --numt2;
        Console.WriteLine($"{numt2}");
        numt2--; 
        Console.WriteLine($"{numt2}");
    }
}