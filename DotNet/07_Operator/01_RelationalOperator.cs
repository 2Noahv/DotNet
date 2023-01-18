// 관계형(비교) 연산자 :
// >, <, >=, <=, ==, !=
using System;

class RelationalOperator
{
    static void Main()
    {
        int firstNum = 10;
        int secondNum = 5;
        bool r = false;

        Console.WriteLine(firstNum > secondNum); // true

        r = (firstNum <= secondNum); // false
        Console.WriteLine(r);

        r = (firstNum == secondNum); // C Family : ==
        Console.WriteLine(r); // flase

        r = (firstNum != secondNum); // C Family : !=
        Console.WriteLine(r); // true

    }
}