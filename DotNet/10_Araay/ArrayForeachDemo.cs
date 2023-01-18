// foreach문으로 배열의 값을 반복해서 사용
class ArrayForeachDemo
{
	static void main()
	{
		float[] arr = { 10.5f, 20.1f, 30.2f };

		float sum = 0.0f;

		// arr 배열의 있는 데이터를 꺼내 원하는
		// 데이터 형식으로 하나씩 하나씩 가져옴
		foreach (float f in arr) // (var f in arr) var형식도 가능
		{
			sum += f;
		}
		System.Console.WriteLine(sum);
	}
}