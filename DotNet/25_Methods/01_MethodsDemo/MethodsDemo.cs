using System;

class MethodsDemo
{
    static void Main()
    {
        var car = new Car33();
        car.Map2("홍길동", "백두산");

        string title2; 
        car.Map(out title2);
        Console.WriteLine($"{title2}");
    }
    
}
