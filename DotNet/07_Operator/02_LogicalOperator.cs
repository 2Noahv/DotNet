// 논리 연산자
// &&(AND) 연산자  : 둘 다 참일때에만 참, 즉 하나라도 거짓이면 거짓
// ||(OR) 연산자   : 하나라도 참이면 참, 즉 둘 다 거짓일때에만 거짓
// !(NOT) 연산자   : 참이면 거짓으로, 거짓이면 참으로

using System;

class LogicalOperator
{
    static void Main()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3); // r = ture && true => ture
        Console.WriteLine(r);

        r = (i != 3) || (j == 3); // r = false && false => flase
        Console.WriteLine(r);

        r = (i >= 5); // r => flase
        Console.WriteLine("{0}", !r); // false <-> true
    }
}