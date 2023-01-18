// 배열(Array): 하나의 이름으로 같은 데이터 형식을 여러개 보관해 놓는 그릇
using System;

class Arraydemo
{
    static void Main()
    {
        // 배열 선언
        // new int 키워드가 주소를 참조함
        int[] eng = new int[3] { 10, 20, 30 } ;

        /*
            인덱스 쌓이는 순서
            eng[2] = 30;
            eng[1] = 20;
            eng[0] = 10;
        */

        for (int i = 0; i < eng.Length; i++)
        {
            Console.WriteLine(eng[i]);
        }

        int[] eng2 = { 10, 20, 30 };

        for (int i = 0; i < eng2.Length; i++)
        {
            Console.WriteLine(eng2[i]);
        }



        // 2차원 배열: 행과 열로 이루어진 배열
        int[,] data = new int[2, 3];

                          // data[0,0]  data[0,1]   data[0,2]
        // 10 1번 학생              10         20          30
                          // data[1,0]  data[1,1]   data[1.2]
        // 20 2번 학생              40         50          60
        // 30                
        // 40
        // 50
        // 60

        // .GetLength(차원)
        int[,] numbers = { { 1, 2, 3 }
                         , { 4, 5, 6 } 
                         };

        for (int i =  0; i < numbers.GetLength(0); i++)
        {
            for( int j = 0; j < numbers.GetLength(1); j++)
            { 
                Console.Write($"{numbers[i,j]}  ");
            }
            Console.WriteLine();
        }


        string[] names = { "C#", "ASP.NET" };
        // names[0]
        
        // 명확한 어디부터 어디까지 출력일 때 사용
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        // 데이터가 있는 만큼 출력일 때 사용
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }


        char[,] arr = new char[2, 2];

        arr[0, 0] = 'A';
        arr[0, 1] = 'B';

		arr[1, 0] = 'C';
		arr[1, 1] = 'D';

        Console.WriteLine($"{arr[0, 0]}, {arr[0, 1]}");
		Console.WriteLine($"{arr[1, 0]}, {arr[1, 1]}");
	}
} 