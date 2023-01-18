// LINQ Distinct(): 컬렉션(시퀀스)에서 중복 제거
using System.Linq;

class LINQ_Distinct
{
    static void Main()
    {
        // Data에 3을 5개 반환 
        var data = Enumerable.Repeat(3, 5); // 3을 5개 반환

        // Distinct를 거치면 중복이 제거된다.
        var result = data.Distinct();

        foreach (var num in result)
        {
            System.Console.WriteLine(num); // 3 출력
        }

        int[] arr = { 2, 2, 3, 3, 3 };
        var r = arr.Distinct();
        foreach (var num in r)
        {
            System.Console.WriteLine(num); // 2, 3
        }

    }

}

