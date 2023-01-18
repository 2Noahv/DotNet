// goto문: 지정한 레이블(책갈피)로 이동하는 구문

using System;

class gotoDemo
{
    static void Main()
    {
        Console.WriteLine("시작");
        Start:
        Console.WriteLine("0, 1, 2 중 하나 입력: _\b");
        int chapter = Convert.ToInt32(Console.ReadLine());

        if (chapter == 1)
        {
            goto Chapter1;
        }
        else if (chapter == 2)
        {
            goto Chapter2;
        }
        else
        {
            goto End;
        }


        // 레이블, goto문을 만나면 실행된다.
        Chapter1:
        Console.WriteLine("1장입니다.");
        goto Start; // 다시 처음으로 Start: (스타트 레이블로)

        Chapter2:
        Console.WriteLine("2장입니다.");
        goto Start; // 다시 처음으로 Start: (스타트 레이블로)

    End:
        Console.WriteLine("종료");
    }
}