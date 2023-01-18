/*
	명령줄 인수(Command-Line Arguments)
		- 명령줄 인수, 애플리케이션 인수
		- 런타임시 명령줄 인수를 Main 메서드로 전달
		- Main 메서드는 매개변수로 문자열 배열을 전달 받음

		public class 명령줄인수 
		{
			static void Main(string[] args) {
				for (int i = 0; i< args.Length; i++) {
					System.Console.WriteLine(args[i]);
				}
			}
		}
*/

using System;

class FunctionNote
{
	// 선언
	static void Sum()
	{
		Console.WriteLine("Sum 메서드 호출 ");
	}
	// 매개변수, 반환값 없을 때 => 사용 가능
	// static void Sum() => Console.WriteLine("합계: ");

	static int Sum (int first, int second)
	{	
		return (first + second);
	}

	// 호출: DotNet.exe 만들어지고 3, 5 넘겨주면 args 배열에 담긴다.
	static void Main(string[] args)
	{
		Sum();
		// FunctionNote.Sum();
		
		// 애플리케이션은(args) 터미널(명령프롬프트)에서 실행된다.
		// Visual Studio -> DotNet 우클릭 -> 디버그 -> 명령줄 인수에 입력
		// int first = Convert.ToInt32(args[0]);
		// int second = Convert.ToInt32(args[1]);
		// Console.WriteLine(Sum(first, second));

		Console.WriteLine(Sum(3, 5));
	}
}