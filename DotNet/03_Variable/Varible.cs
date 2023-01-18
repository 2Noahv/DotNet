/*
    변수(Variable): 프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇
    [1] 변수 만들기(선언)
    int i; //   i 이름으로 변수 만들기

    [2] 변수에 값을 저장하기(대입, 할당)
    i = 1234;

    [3] 변수에 들어 있는 값 사용하기(참조)
    Console.WriteLine(i);   // 1234
*/
using System;

   public class Varible
    {
        static void Main()
        {
        int number; //[1] 정수형 변수 선언하기
        number = 7; //[2] 변수에 값 대입(할당)하기

        //[3] 변수이 값을 화면에 출력하기
        Console.WriteLine(number);  
        Console.WriteLine("{0}", number);

        // 리터널
        Console.WriteLine(1234);    //[1] 1234: 정수 리터널
        Console.WriteLine(3.14f);   //[2] 3.14: 실수 리터널
        Console.WriteLine('A');     //[3] A: 문자 리터널
        Console.WriteLine("HELLO"); //[4] HELLO: 문자열 리터널

        int a, b, c;

        // 여러 개의 변수를 선언하고 같은 값으로 초기화하기
        a = b = c = 10;

        Console.WriteLine("{0},{1},{2}", a, b , c);


        // 상수(Constant): 변하지 않는 변수, 읽기 전용 변수
        const int MAX = 1_234; 
        // 정수 형식의 상수 선언과 동시에 초기화  _는 , 대신 사용
             
        Console.WriteLine("최댓값: {0}", MAX);

    }

}
