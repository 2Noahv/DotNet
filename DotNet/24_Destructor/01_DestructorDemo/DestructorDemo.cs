using System;

namespace ConsoleTest
{
    class Cart2
    {
        private string _name;
        public Cart2() : this("기본자동차") { }
        public Cart2(string name)
        {
            _name = name;
            Console.WriteLine($"[1] {this._name} 생성, 조립, 시동");
        }
        public void Go() => Console.WriteLine($"[2] {this._name} 달리다.");

        /* 
        소멸자 (가비지 컬렉터가 자동을 할거라 알고만 있자)
        ~Cart2()
        {
            Console.WriteLine($"[3] {this._name} 소멸");
        }
        */
    }

    class DestructorDemo
    {
        static void Main()
        {
            Cart2 car1 = new Cart2();
            car1.Go();
            Cart2 car2 = new Cart2("캠핑카");
            car2.Go();            
        }

    }
}