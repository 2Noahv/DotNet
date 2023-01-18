// 5명의 학생의 국어 점수를 배열에 저장 후 총점과 평균을 구하고 각 학생의 평균과의 차이를 구하시오.
// // 입력 값: 100, 90, 80, 70, 60
using System;

class ArrayEx
{
	static void Main()
	{
		int[] kor = { 100, 90, 80, 70, 60 };

		int sum = 0;		// 총점
		float avg = 0.0f;   // 평균
		
		for (int i = 0; i < kor.Length; i++)
		{
			sum = sum + kor[i];
		}
		avg = sum / (float)kor.Length;
		Console.WriteLine("배열로 국어점수 총점 평균 구하기");
		Console.WriteLine($"총점: {sum}\n평균: {avg}");
		Console.WriteLine();

		for (int i = 0; i < kor.Length; i++)
		{
			float diff = (float)kor[i] - avg;
			Console.WriteLine($"점수: {kor[i]},\t차이: {diff}");
		}
	}
}