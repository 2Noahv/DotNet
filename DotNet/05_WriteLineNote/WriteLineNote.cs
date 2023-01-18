using System;

class WriteLineDemo
{
    public static void Main()
    {
        // 숫자 이외의 데이터 형식: bool, chart, string 등의 키워드로 숫자 이외의 데이터 저장
        // char 키워드: 문자 데이터 형식 변수를 선언
        char grade = 'A';
        char kor = '가';

        // WriteLine() 매서드의 기본 제공 기능 사용
        // string 키워드: 문자열 데이터 형식 변수를 선언
        string hw = "Hello World";
        string h = "H";

        string name = "홍길동";
        Console.WriteLine("안녕하세요. {0} 입니다.", name);

        string multiLines = @"
            안녕하세요.
            반갑습니다.
        ";

        Console.WriteLine(multiLines);

        // ($" {}") 권장
        // StringInterpolation
        // 문자열 보간법(보간된 문자열)
        string message = "string Interpolation"; 
        Console.WriteLine($"Message: {message}");

        Console.WriteLine("Message: {0}", message);

        int number = 3;
        string result = "홀수";
        Console.WriteLine($"{number}은(는) {"result"}");

        // PlaceHolder
        Console.WriteLine("Hello" + ", " + "World");

        // String.Format() 매서드 : 문자열 연결 관련 주요 기능 제공
        string masg = string.Format("{0}님, {1}", "홍길동", "안녕하세요.");
        Console.WriteLine(masg);

        //[?] 논리 자료형: 참(True) 또는 거짓(False)값 저장
        bool bln1 = true;
        bool bln2 = false;

        // 래퍼 형식: int, string과 같은 기본 형식을 클래스 또는 구조체로 감싼 .NET 형식
        int number1 = 1234;       // int 키워드 : 기본형식
        Int32 number2 = 1234;     // System.Int32 구조체: .NET 형식
        Console.WriteLine($"{number1}, {number2}");

        string str1 = "안녕";     // string 키워드: 기본형식
        String str2 = "안녕";     // System.String 클래스: .NET 형식
        Console.WriteLine($"{str1}, {str2}");

        Console.WriteLine($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}"); 
    }
}

