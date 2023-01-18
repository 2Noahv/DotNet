// LINQ Take(): 컬렉션(시퀀스)에서 지정한 수만큼의 데이터 가져오기
using System.Linq;

class LINQ_Take
{
    static void Main()
    {
        // Enumerable 클래스의 Range 로 0 ~ 99 까지 int 타입으로 담긴다.
        var data = Enumerable.Range(0, 100);

        // 입력받은 n의 2의 배수를 Take에서 5개를 반환함
        var even = data.Where(n => n % 2 == 0).Take(5); // 짝수 5개

        foreach (var e in even)
        {
            System.Console.WriteLine(e);
        }
    }

}

