/*
    조건 연산자
    3항 연산자 : 조건 연산자 : "?:"
    조건 연산자(3항연산자)
        - 조건에 따라 두 값 중에 하나를 여산결과로 전달
        - 뒤에서 배울 if~else 문의 단축 표현

    형식 : (조건) ? 수식1 : 수식2
        - 조건인 참이면 앞 문장 수행, 거짓이면 뒷 문장 수행
        - var result = i > 0 ? 0 : 1;
 */
using System;

class ConditionalOperator
{
    static void Main()
    {
        int number = 3;

        string result = (number % 2 == 0) ? "짝수" : "홀수";

        Console.WriteLine($"{number}는 {result}입니다.");
    }
}