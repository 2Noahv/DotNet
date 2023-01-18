using System;

class TryFinalyDemo
{ 
	static void Main()
	{
		Console.WriteLine("[1] 시작");

		//[!] 에러가 발생할만한 코드 들어오는 영역
		try
		{
			Console.WriteLine("[2] 실행");
			throw new Exception(); // 무작정 에러 발생
		}
		//[!] 예외가 발생하면 잡아주는 역할
		catch (Exception ex)
		{
			Console.WriteLine($"[2] 예외(에러)가 발생됨: {ex.Message}");
		}
		//[!] try절에서 에러가 발생하던 안하던 반드시 실행하는 영역(마무리 영역)
		finally
		{
			Console.WriteLine("[3] 종료");
		}

		// 생성자 던져주는 방법
		try
		{
			//[2] Exception 클래스에 여러 에러 메시지 지정하여 무조건 에러 발생
			throw new Exception("내가 만든 에러");
		}
		catch (Exception e) 
		{
			Console.WriteLine($"예외(에러)가 발생됨: {e.Message}");
		}
		finally
		{
			Console.WriteLine("try 구문을 정상 종료합니다.");
		}
	}
}



