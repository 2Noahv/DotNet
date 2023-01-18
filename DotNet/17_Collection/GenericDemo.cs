// 컬렉션(Collection): 배열, 리스트, 사전을 사용하여 관련 개체의 그룹을 만들고 관리
// 제네릭: Cup<T>를 Cup of T로 발음하여 형식 매개 변수인 T에 따른 Cup 클래스의 객체 생성

using System;
using System.Collections.Generic;


class GenericDemo
{
	static void Main()
	{
		List<int> numbers = new List<int>();
		numbers.Add(10);
		numbers.Add(20);

		for (int i = 0; i < numbers.Count; i++)
		{
			Console.WriteLine(numbers[i]); ;
		}

		foreach (var number in numbers)
		{
			Console.WriteLine(number);
		}

		List<string> colors = new List<string>();
		colors.Add("red");
		colors.Add("green");
		colors.Insert(0, "blue");
		foreach (var color in colors)
		{
			Console.WriteLine($"{color}");
		}

		Dictionary<int, string> todos = new Dictionary<int, string>();
		todos.Add(1, "C#");
		todos.Add(2, "ASP.NET");
		todos.Add(3, "...");

		foreach (var item in todos)
		{
			Console.WriteLine($"{item.Key}: {item.Value}");
		}

		/*
		foreach (KeyValuePair<int, string> todo in todos)
		{
			Console.WriteLine($"{0}{1}, {todo.Key}, {todo.Value}");
		}
		*/
	}  
}
