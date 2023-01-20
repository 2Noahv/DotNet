using System;

// 원하는 부분 드래그 + ctril + s + k  코드 감싸기 단축키
namespace MyNamespace
{
    public class Myclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("네임스페이스");
            Foo.Car car1 = new Foo.Car(); car1.Go();
            var car2 = new Bar.Car(); car2.Go();
        }
    }
}