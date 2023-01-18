// 사용자한테 얻은 정보를 변수에 저장하기
// Consol.ReadLine()으로 콘솔(터미널)로부터 데이터 입력 받기
using System;

class ReadLineDemo
{
    static void Main()
    {
        
        // Console.ReadLine();  이 시점에서 대기하는 효과
        Console.Write("이름: ______\b\b\b\b\b\b");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}님 안녕하세요.");

        // Read()
        int x = Console.Read();
        
        Console.WriteLine(x); // 아스키 코드

        Console.WriteLine(Convert.ToChar(x)); // 실제 문자
        

        // 문자열을 정수로 캐스팅 방법
        Console.Write("정수:");
        string num1 = Console.ReadLine();   // "1234" 문자열
        int number1 = Convert.ToInt32(num1); // 1234 정수
        Console.WriteLine($"{num1}은(는) 문자열 \"1234\" 출력이다.");
        Console.WriteLine($"{number1}은(는) 정수형 1234 출력이다.");

        /*
            2진수 문자열로 변환하기
            int number = 10;
            Convert.ToString(number, 2)
            "1010"
            Convert.ToString(number, 2).PadLeft(8, '0')
            "00001010"
            Convert.ToString(number, 2).PadLeft(8, '_')
            "____1010"
            
            2진수를 10진수로 바꾸기
            Convert.ToInt32("00001010", 2)
        */

        // var 키워드: 암시적으로 형식화된 로컬 변수
        var age = 21;
        // int age = 21; 같은 말
        Console.WriteLine(age.GetType());

        // version만 요청하면 version.ToString()과 동일함
        // 문자열로 변환되어 0은 제거됨
        var version = 8.0;
        Console.WriteLine(version.GetType());
        

        var Nname = "Test";
        Console.WriteLine(Nname.GetType());

        // danamic 
        dynamic Nname2 = 1.0;
        Console.WriteLine($"{Nname2}");
        Nname2 = "문자문자문자";
        Console.WriteLine($"{Nname2}");
        

        // default 값 초기화
        int i1 = default;
        double d1 = default;
        char c1 = default;
        string s1 = default;
        Console.WriteLine($" {i1}으로 초기화\n {d1}으로초기화\n{c1}\\0으로 초기화\n {s1}null으로 초기화");

    }
}

