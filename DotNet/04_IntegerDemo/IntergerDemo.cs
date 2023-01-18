using System;

class IntergerDemo
{
    public static void Main()
    {
        // Int32 객체는 DotNet 전용
        int min = Int32.MinValue;
        int max = Int32.MaxValue;

        Console.WriteLine("int 변수의 최솟값: {0}", min);
        Console.WriteLine("int 변수의 최댓값: {0}", max);

        // 부호(+, -) 있는 정수 데이터 형식: sbyte, short, int, long
        sbyte sb = 127;
        short st = 32_767;
        int i = Int32.MaxValue;
        long l = Int64.MaxValue;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", sb, st, i, l);

        // 부호 없는 정수 데이터 형식: byte, ushort, uint, ulong
        byte be = byte.MaxValue;
        ushort ust = ushort.MaxValue;
        uint ui = uint.MaxValue;
        ulong ul = ulong.MaxValue;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", be, ust, ui, ul);

        // decimal 키워드: 실수형 데이터 형식(128비트 10진수)
        // 이자, 돈 관련 된 쪽에서 쓰자
        decimal money1 = 12.34M;
        decimal money2 = 12.34m;

        // float 키워드: 실수형 데이터 형식(32비트 부동 소수점 숫자)
        float f1 = 3.14F;
        float f2 = 3.14f;

        // double 키워드: 실수형 데이터 형식(64비트 부동 소수점 숫자)
        double PI = 3.141592;
        double pi1 = 3.14D;
        double pi2 = 3.14d;

        // null 가능 형식, DB연결
        int? x = null;
    }
}
