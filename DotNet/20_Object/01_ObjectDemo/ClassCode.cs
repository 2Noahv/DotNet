using System;

public class Car
{
    // 멤버
    public void Go() => Console.WriteLine("Run...");
    public override string ToString() => "My Car";
}

public class ClassOne
{
    public static void Hi() => Console.WriteLine("Hi");
}

public class ClassTwo
{
    public void Hi() => Console.WriteLine("Hi");
}

public class ClassCode
{
    static void Main()
    {
        // new키워드로 생성자 호출
        // GetHashCode() 메서드는 int32 타입의 코드를 만들어줌
        ClassCode classCode1 = new ClassCode();
        int tcode1 = classCode1.GetHashCode();
        Console.WriteLine(tcode1);

        ClassCode classCode2 = new ClassCode();
        int tcode2 = classCode2.GetHashCode();
        Console.WriteLine(tcode2);

        Car car1 = new Car();
        car1.Go();
        Car car2 = new Car();
        car2.Go();
        var car3 = new Car();
        car3.Go();

        Car car = new Car();
        Console.WriteLine(car);

        // static
        ClassOne.Hi();

        // Instance
        ClassTwo two = new ClassTwo();
        two.Hi();
    }

}
