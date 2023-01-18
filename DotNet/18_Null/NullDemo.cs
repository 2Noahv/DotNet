// null: 아무 것도 없음을 의미하는 리터널, 개체가 아무 것도 참조하지 않음을 null 참조라 함
using System;
using System.Collections.Generic;

class NullDemo
{
    static void Main()
    {
        int i = 0;          // 값형(Value Type)
        string s = null;    // 참조형(Refernce Type)
        s = "안녕하세요.";   // 어딘가 만들어진 "안녕하세요"를 s 변수가 참조
        string empty = "";  // 빈값(Empty)은 null과는 다름

        // Nullable<T> 구조체를 사용하여 널 가능 형식 변수 만들기
        Nullable<bool> bln = null;
        Console.WriteLine(bln.HasValue);

        // System.Nullable<T> 제네릭 클래스: int?, double? 사용을 권장함
        // 참조 형식: null 할당 가능
        string s2 = null;
        int? i2 = null;
        double? d2 = null;

        // ?? 연산자(널 병합 연산자(Null Coalescing Operator))
        string nullValue = null;
        string message = "";

        //[1] if 구문으로 null 값 비교
        nullValue = null;
        if (nullValue == null)
        {
            message = "[1] null이면 새로운 값으로 초기화합니다.";
        }
        Console.WriteLine(message);

        //[2] ?? 연산자로 null 값 비교
        nullValue = null;
        message = nullValue ?? "[2] null이면 새로운 값으로 초기화합니다.";
        Console.WriteLine(message);
        nullValue = "Hello";
        message = nullValue ?? "null이면 새로운 값으로 초기화합니다.";
        Console.WriteLine(message);

        int? x = null;
        int y = x ?? 100; // x가 null이면 100으로 초기화
        int z = x ?? default; // 정수형의 기본값인 0으로 초기화
        
        // 널 조건부 연산자(Null Conditional)
        // ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 변환
        // ?. 연산자는 엘비스의 머리 모양과 비슷하다고 하여 Elvis 연산자라고 함
        
        double? d = null;
        d?.ToString();
        // d가 null이면 null값을, 아니면 ToString을 반환

        int? len;
        string message2;
        message2 = null;
        len = message?.Length; // null

        message2 = "안녕";
        len = message2?.Length; // 2

        List<string> list = null;
        int? numberOfList;

        //[1] 리스트가 null이면 null 반환
        numberOfList = list?.Count; // null

        list = new List<string>();
        list.Add("안녕하세요."); list.Add("반갑습니다.");

        //[2]리스트가 null이 아니므로 Count 속성의 값인 2 반환
        numberOfList = list?.Count; // 2


        // 널 병합 연산자와 널 조건부 연산자 함께 사용하기
        // ?? 연산자: 컬렉션이 null이 아니면 해당 값 반환, null이면 뒤에 지정한 값 반환
        // ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 변환
        int num;
        List<string> list2;

        //[1] 컬렉션 리스트가 null이면 Count를 읽을 수 없기에 0으로 초기화
        list2 = null;
        num = list2?.Count ?? 0; // null이면 0 반환, 오른쪽 값 사용
        Console.WriteLine(num);

        //[2] 컬렉션 리스트가 null이 아니면 Count 속성의 값을 사용
        list2 = new List<string>();
        list2.Add("또 만나요.");
        num = list2?.Count ?? 0; // null이 아니기 때문에 왼쪽 값 사용
        Console.WriteLine(num);
    }
}
