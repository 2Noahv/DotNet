// break 문: for, while, do 구문을 빠져나가는 역할

using System;

class breakDemo
{
    static void Main()
    {    
       // for
       for (int i = 0; i < 100; i++)
        {
            if ( 5 == i)
            {
                break; // i == 5일 때 for문 종료
            }
            Console.WriteLine($"{(i + 1)}번 반복\t");
        }

        // while
        int j = 0;
        while (true)
        {
            if (j == 5)
            {
                break;
            }
            Console.WriteLine($"{(j + 1)}번 반복\t");
            j++;
        }
    }
}