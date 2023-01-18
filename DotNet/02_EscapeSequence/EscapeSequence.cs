using System;

// 프로그래밍 언어 특성상 표현할 수 없는 기능, 문자를 표현해준다.
public class EscapeSequence
{
    public static void Main()
    {
        // \n: 줄바꿈
        Console.WriteLine("안녕\n하세요.");

        // \t: 탭만큼 들여쓰기
        Console.WriteLine("반갑\t습니다.");

        // \r: 캐리지리턴: 줄 맨 앞으로... -> \r\n
        Console.Write("또 만나요.\r");
        Console.WriteLine();

        // \': 작은따옴표 문자 하나 표현
        Console.WriteLine(" '낼' \'만나요.\' ");

        // \": 큰따옴표 문자 하나 표현
        Console.WriteLine(" \"어디\"에서요? ");

        // \\: 백(역)슬래시(\) 기호 자체를 표현
        Console.WriteLine(" \\ : 백슬래시 표현");

        // 백슬래시 다음에 나오는 문자 하나는 이스케이프 문자로 본다.
        Console.WriteLine(" c:\\Home\\DevLec\\Default.aspx ");

        // 문자열 앞에 @ 기호를 붙이면 문자열 자체로 본다.
        Console.WriteLine(@"afdsdfasfasddf");

        // 더 많은 문자 이스케이프는 MSDN 온라인 사이이트
        // (http://www.microsoft.com/korea/msdn/)에서 검색
    }
}