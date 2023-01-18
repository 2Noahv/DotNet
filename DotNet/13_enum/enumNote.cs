// 열거형: 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수 집합을 정의
// C#에 열거형이 많이 내장되어 있다.
using System;

// 열거형 만들어보기
public enum Animal 
{ 
	Mouse,
	Cow = 5, 
	Tiger  // 5이후 기입 안하면 자동으로 6
}

class enumNote
{
	static void Main()
	{
		// DotNet의 콘솔컬러 열거형으로 인식해줌
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Red");
		Console.ResetColor();
		
		Console.ForegroundColor = ConsoleColor.Green;
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.WriteLine($"{nameof(ConsoleColor.Green)} & {nameof(ConsoleColor.Blue)}");
		Console.ResetColor();

		Animal animal = Animal.Tiger;
		Console.WriteLine($"{nameof(Animal.Tiger)}");
	}
}  



