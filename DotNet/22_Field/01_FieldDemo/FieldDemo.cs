// 필드(Feild): 클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇
using System;

public class Say
{
    private string message = "반갑습니다."; // 필드
    public void Hi()
    {
        Console.WriteLine(this.message); // 
    }
}

public class Cart
{
    private string color = "Red";
    public string GetColor() => color;
}

public class Person
{
    private string name = "홍길동";
    private const int m_age = 21; // 필드 == 멤버 변수, 전역 변수
    private readonly string _NickName = "RedPlus";
    private string[] _websites = { "그냥그냥", "비주얼아카데미" };

    // 선언 따로, 초기화 따로
    // readonly는 생성자에 의해서 초기화 가능
    public Person()
    {
        _NickName = "REdPlus";
    }

    // private된 필드들을 메서드로 호출 가능
    public void ShowProfile() => 
        Console.WriteLine($"{name} - {string.Join(", ", _websites)}");

}

public class FieldDemo
{
    private static string message = "안녕하세요."; // 필드, 전역 변수
    public static void Hi() => Console.WriteLine(message);
    public static void Main(string[] args)
    {
        int number = 1_234; // 변수, 지역 변수
        Console.WriteLine(number);
        Console.WriteLine(message);
  
        Say say = new Say(); 
        say.Hi();

        Cart cart = new Cart();
        Console.WriteLine(cart.GetColor());

        Person my = new Person();
        my.ShowProfile();
    }

  
}
