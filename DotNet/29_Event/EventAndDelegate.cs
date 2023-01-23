// 이벤트(Event): 특정 상황이 발생할 때 객체 또는 클래스에서 알림을 제공할 수 있도록 하는 멤버
using System;

namespace EventAndDelegateDemo
{
    // 이벤트 구독자(Subscriber)
    class EventAndDelegate
    {        
        static void Main()
        {
           Car car = new Car();
           car.FuelEmptyReached += Car_FuelEmptyReached;
           car.Go();
           //car.OnFuelEmptyReached();
           car.Go();

        }

        // 이벤트 처리기(핸들러): Handler
        private static void Car_FuelEmptyReached() =>
            Console.WriteLine("연료 부족");
        
    }
}