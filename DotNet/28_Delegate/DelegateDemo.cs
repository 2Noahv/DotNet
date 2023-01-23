//[?] 대리자(Delegate): 대신, 위임, 함수 포인터, 메서드 대신 호출, 대리 운전, 메서드의 매개 변수로 전달

using System;

 class DelegateDemo
 {
    static void GoForward() => Console.WriteLine("직진");
    static void GoLeft() => Console.WriteLine("좌회전");
    delegate void CarDriver(); // 대리자 형식 생성
    static void Main() 
    {
        //GoForward(); //[1] 내가 직접 운전했다 라고 생각하자
        //CarDriver goHome = new CarDriver(GoForward); //[2] 대리 운전이라고 생각하자
        CarDriver goHome = GoForward;
        goHome += GoLeft;

        // 무명 메서드 사용
        goHome += delegate () { Console.WriteLine("우회전"); };
        //goHome += delegate { Console.WriteLine("후진"); };
        goHome += () => Console.WriteLine("후진"); // 람다 식
        goHome();           // goHome.Invoke();
        Console.WriteLine();

        // 내장된 대리자 형식을 통해서 직접 대리자 객체 생성: Fun<T>, Action<T>, Predicate<T>, ...
        Action driver = GoForward;
        driver += GoLeft;
        driver += delegate () { Console.WriteLine("우회전"); };
        driver += () => Console.WriteLine("후진");
        driver(); // 트리거 (방아쇠)

        Action go = () => Console.WriteLine("운전");
        go();

        RunLambda(() => Console.WriteLine("매개 변수로 람다 식(함수이름, 무명 메서드) 전달"));
    }
    static void RunLambda(Action action) => action();
 }
