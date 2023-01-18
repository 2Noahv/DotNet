// C#은 string 키워드가 유니코드는 2byte 코드로 영문, 한글 구분하지 않고 1자로 인식
using System;

class StringFunction
{
	static void Main()
	{
		string message = "hello World";

		Console.WriteLine(message.ToUpper());   // 대문자
		Console.WriteLine(message.ToLower());

		Console.WriteLine(
			message.Replace("hello", "안녕하세요.").Replace("World", "세계."));
		
		// System.String 클래스 == string 키워드
		String s1 = "안녕하세요."; // String 클래스
		string s2 = "반갑습니다."; // string 키워드

		Console.WriteLine($"{s1}\n{s2}");

		// 문자열 연결: 더하기 연산자, String.Concat() 메서드
		string s3 = "문자열" + "붙이기";
		string s4 = String.Concat("붙이기", "문자열.");
		Console.WriteLine($"{s3}\n{s4}");

		// 문자열의 길이: String.Length 속성
		string s5 = "Hello.";
		string s6 = "안녕하세요.";
		Console.WriteLine($"{s5.Length}, {s6.Length}");

		// ToCharArray() 메서드로 문자열을 문자 배열로 변환하기
		string ss = "char배열";
		char[] ch = ss.ToCharArray();
		for (int i = 0; i < ch.Length; i++)
		{
			Console.WriteLine(ch[i]); // '안', ... '.'
		}		
	}
}