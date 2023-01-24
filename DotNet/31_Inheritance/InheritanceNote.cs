using System;

namespace DotNet
{
    public enum CarType { 전기, 내연기관 }

    // 추상클래스
    // 상속을 줄 목적으로 abstract 키워드를 사용
    public abstract class CarBase
    {
        // 추상 클래스의 추상 메서드, 본문 X, 시그니처 O = 표준(강제) => 인터페이스
        public abstract void Left();
        public void Back() => Console.WriteLine("후진하다.");
        
        // 자식에게만 멤버 노출
        protected string LeftMessage { get; private set; } = "자회전하다.";
    }

    public class Car : CarBase 
    {
        public CarType Style { get; private set; }
        public Car(CarType carType)
        {
            this.Style = carType;
        }

        // abstract 상속하는 모든 클래스들은 추상 메서드를 구성해줘야 한다.
        // override 재정의 
        public override void Left() => Console.WriteLine(base.LeftMessage);
        public void Go() => Console.WriteLine("달리다.");     
    }

    public class Benz : Car // Car 클래스 상속 받음, Sub : Base
    {
        // 생성자 포워딩
        // 생성자는 상속이 안된다.
        // this는 나 자신, base는 부모의 생성자를 의미
        public Benz() : this(CarType.내연기관) { }           
        public Benz(CarType carType) : base(carType) { }        
    }

    public class Tesla : Car // 따라서, Child : Parent
    {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType) { }
    }

    // 봉인(최종) 클래스, seald 키워드 사용으로 다른 클래스가 상속할 수 없음
    public sealed class Future : Car
    {
        public Future() : this(CarType.전기) { }
        public Future(CarType carType) : base(carType) { }
        
        // new 키워드로 새롭게 정의
        public new void Go()
        {
            base.Go();
            Console.WriteLine("날다.");
        }
    }

    // 모든 클래스들은 Object를 상속받지만 생략되어 있다.
    class InheritanceNote : Object
    {

        static void Main()
        {
            Benz benz = new Benz();
            benz.Go();
            Console.WriteLine($"{benz.Style}");
            benz.Back();
            benz.Left();
            Console.WriteLine();

            Tesla tesla = new Tesla();
            tesla.Go();
            Console.WriteLine($"{tesla.Style}");
            tesla.Back();
            tesla.Left();
            Console.WriteLine();

            Future future = new Future();
            future.Go();

        }
    }
    
}
