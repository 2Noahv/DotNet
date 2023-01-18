// 예외처리
// try-catch-finally, throw를 사용하여 예외 처리하기
using System;

class TryCatchDemo
{
	static void Main()
	{
		// 예외가 자주 발생할 것 같은곳에 사용한다.
		// [1] 예제
		try
		{
			int[] arr = new int[2];
			arr[100] = 1234; // 예외 발생: System.IndexOutOfRangeException
		}
		catch
		{
			Console.WriteLine("에러가 발생했습니다.");
		}

		try
		{
			int[] arr = new int[2];
			arr[100] = 1234; // 예외 발생: System.IndexOutOfRangeException
		}
		catch (Exception ex) // ex 변수에는 예외에 대한 상세 정보가 담김
		{
			Console.WriteLine(ex.Message);
			// ex.ToString()이랑 같음
			Console.WriteLine(ex);			
		}

		// [2] 예제
		string inputNumber = "3.14";
		int number = 0;

		try
		{
			number = Convert.ToInt32(inputNumber);
			Console.WriteLine($"입력한 값: {number}");
		}
		catch (FormatException fe) // 입력 문자열의 형식이 잘못되었습니다. 출력
		{
			Console.WriteLine($"에러 발생: {fe.Message}");
			Console.WriteLine($"{inputNumber}는 정수여야 합니다.");
		}

		// [3] 런타임 오류 예제
		try
		{
			int now = DateTime.Now.Second;
			Console.WriteLine($"[0] 현재 초: {now}");

			//[!] 실행시간이 짝수이면 0으로 나누기에 에러가 발생
			int result = 2 / (now % 2);
			Console.WriteLine("[1] 홀수 조에서는 정상 처리");
		}
		catch
		{
			Console.WriteLine("[2] 짝수 조에서는 런타임 에러 발생");
		}
	}
}