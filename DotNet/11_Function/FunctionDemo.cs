/*
	함수(Funciton) 또는 메서드(Method)
	코드를 반복하여 사용하도록 하나의 이름으로 만들어 놓은 코드의 집합
	
	재귀(Recursion): 함수가 자기 자신을 다시 호출하는 것
	Tree구조 탐색, HTML DOM 구조 탐색에 용이하다.

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

class FunctionDemo
{
	//[1] Show 메서드(함수) 선언
	static void Show()
	{
		Console.WriteLine("Hello World");
	}

	//[2] 매개 변수가 있는 함수
	static void ShowMessage(string message)
	{	
		Console.WriteLine(message); // 넘어온 매개 변수의 값을 출력
		/* 
			파라미터 정의
				- 메서드명 다음에 나오는 괄호안에 위치
				- 각 파라미터에 데이터형과 이름지정

			파라미터를 사용한 메서드 호출
				- 각 파라미터에 값이 전달됨
		*/
	}

	//[3] 반환 값이 있는 함수
	static string GetString()
	{
		return "반환값(Return Value)"; // return 키워드로 단순 문자열 반환
		/*
			반환 값
			반환값이 있는 메서드 선언
			return 키워드를 구문에 추가
				- 반환값 설정
				- 호출한 곳으로 반환값 반환
			반환값이 있는 메서드는 반드시 값을 리턴해야 함
		*/
	}

	//[4] 메서드 오버로드(여러번 정의)
	//	  클래스 안에서 메서드 이름 공유: 다중 정의
	//	  C++/C#/Java
	//		- 컴파일러는 매개변수의 타입으로 구분해서 호출

	// GetNumber 함수: int 매개 변수
	static void GetNumber(int number)
	{
		Console.WriteLine($"Int32: {number}");
	}

	// GetNumber 함수: long 매개 변수
	static void GetNumber(long number)
	{
		Console.WriteLine($"Int64: {number}");
	}


	// Main 메서드(함수)
	static void Main()
	{
		//[1] 호출
		Show(); 

		//[2] 호출
		ShowMessage("매개 변수"); // ShowMEssage() 함수에 "매개 변수" 문자열 전달
		ShowMessage("Parameter");
		
		//[3] 호출
		string returnValue = GetString();
		// GetString() 함수 호출 후 반환된 반환값을 returnValue 변수에 저장

		//[4] 호출
		GetNumber(1234);	// Int32: 1234
		GetNumber(1234L);	// Int64: 1234
	}
}