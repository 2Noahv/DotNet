// class

using System;

class Square
{
	public int Width;
	public int Height;
	public static string Creator;
}


class classDemo
{
	static void Main()
	{
		// 객체 없이 static(정적) 맴버 변수로 호출
		Square.Creator = "RedPuus"; 

		// Object, Instance 선언 후  
		Square square1 = new Square();
		square1.Width = 100;
		square1.Height = 100;
		
		/*
			 is 연산자는 ~가 ~인지 가능한지 물어보는 것
			string s = "Foo";
			s is string

			as 연산자는 변환이 가능하면 변환해주고 그렇지 않으면 null
			object x = 1234;
			string s = x as string;
			s

			.NET -> C#
			Built -In class
			Console, Environment, Math, Random . . .
			User-Defined Class
			MyClass, Car, Product, Person ...
			Instance vs Static
			등등 다음에 정리
		*/
	}
}

