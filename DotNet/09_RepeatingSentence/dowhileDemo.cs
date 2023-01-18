// 반복문

using System;

class dowhileDemo
{
    static void Main()
    {
        int count = 0; // 초기식

        do
        {
            Console.WriteLine("안녕하세요"); // 실행문
            count++; // 증감식
        } while (count < 3); // 조건식


        // do 문을 사용하여 1부터 5까지의 합
        int sum = 0;
        int i = 1;
        do
        {
            sum += i;
            i++;
        } while (1 <= 5);


        // 1 ~ 100까지 3과 4의 배수인 정수의 합 구하기
        int j = 1; // 초기식
        do
        {
            if (j % 3 == 0 && j % 4 == 0) // 조건식(필터링)
            {
                sum += j; // 실행문(문장)
            }
            j++; // 증감식
        } while (j < 100); // 조건식(평가할 식)
        Console.WriteLine(sum); 
    }
}