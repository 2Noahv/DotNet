/*
	구조체
	- 여러개의 데이터 형식을 하나로 묶어서 관리하는 개념
	- 하나의 이름으로 여러 데이터 형을 보관
	- 클래스 구조보다 접근이 빠름(스택 사용)
	- 상속 불가능
	- 프로그램 내에서 데이터 보관 용도로 사용

	데이터 보관 관점 비교
	- 변수(Variable)
	  하나의 이름으로 하나의 데이터 형식을 하나만 보관하는 그릇
	
	- 배열(Array)
	  변수 확장
      하나의 이름으로 하나의 데이터 형식을 여러개 보관

	- 구조체(Struct)
	  변수/배열의 확장
	  하나의 이름으로 여러개의 데이터 형식을 하나/여러 개 보관

	  구조체 선언 및 사용
		public struct Employee
		{
			public string Name;
			public int Age;
		}

		Employee companyEmployee;
		companyEmployee.Name = "RedPulus";
		companyEmployee.Age = 21;
 */


//[?] 구조체: 하나 이상의 변수 또는 배열을 묶어서 관리
// 접근지정자 Public (전역 공개) 사용
// 기본 접근지정자는 private(비공개) 제공됨
using System;

struct Point
{
	public int X;
	
	public int Y;
}


// 구조체 성적처리 막대 그래프 만들어보기
struct Score
{
	public string Name;
	public int Kor;
	public int Eng;
	public int Tot;
	public int Avg;
	public int Graph;

}



class StructDemo
{
	static void Main()
	{
		Point point;
		point.X = 100;
		point.Y = 200;
		Console.WriteLine($"X: {point.X}, Y : {point.Y}");


		Score[] scores = new Score[3];
		scores[0].Name = "홍길동"; scores[0].Kor = 100; scores[0].Eng = 90;
		scores[1].Name = "백두산"; scores[1].Kor = 90; scores[1].Eng = 80;
		scores[2].Name = "한라산"; scores[2].Kor = 90; scores[2].Eng = 70;

		for (int i = 0; i< 3; i++)
		{
			scores[i].Tot = scores[i].Kor + scores[i].Eng;
			scores[i].Avg = scores[i].Tot / 2;
			scores[i].Graph = scores[i].Avg / 5;
		}

		Console.WriteLine("이름\t총점\t평균\t막대 그래프");

		for(int i = 0; i < 3; i++)
		{
			Console.Write(
				$"{scores[i].Name}\t{scores[i].Tot}\t {scores[i].Avg}\t");
			for (int j = 0; j < scores[i].Graph; j++)
			{
				Console.Write("★");
			}
			Console.WriteLine();
		}
	}
}
