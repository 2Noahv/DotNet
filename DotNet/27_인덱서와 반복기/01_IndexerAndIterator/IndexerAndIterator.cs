using System;
using System.Collections;

namespace IndexerAndIteratorDemo
{
    class TcarT
    {
        //[1] 필드
        private string[] names;
        //[2] 생성자
        public TcarT(int length)
        {
            names = new string[length];
        }
        //[3] 인덱서
        public string this[int index]
        { 
            get { return names[index]; }
            set { names[index] = value; }
        }

       //[4] 반복기(이터레이터)
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++) 
            {
                yield return names[i];
             // 호출자(Caller)에게 컬렉션 데이터를 하나씩 리턴할 때 사용한다.
             // Enumerator(Iterator)라고 불리는 이러한 기능은 집합적인 
             // 데이터 셋으로부터 데이터를 하나씩 호출자에게 보내주는 역할을 한다.
             // yield return : 컬렉션 데이터를 하나씩 리턴하는데 사용
             // yield break  : 리턴을 중지하고 iteration 루프를 빠져나올 때 사용
            }
        }
    }

    class IndexerAndIterator
    {
        static void Main()
        {
            TcarT cars = new TcarT(3);
            cars[0] = "CLA";
            cars[1] = "CLS";
            cars[2] = "AMG";

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

}