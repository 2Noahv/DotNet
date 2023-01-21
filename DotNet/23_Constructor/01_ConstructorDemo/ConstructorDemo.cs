using System;

public class Tcar
{
    // 필드
    private string name;

    // 생성자 포워딩
    // public Tacr() : this("기본자동차") { }

    // 생성자
    // 초기화의 목적
    public Tcar()
    {
        // 기본 생성자, 생성자 메서드
        // Console.WriteLine("[1]자동차 객체를 생성합니다. 조립, 시동걸기");
        name = "기본자동차";
    }

    // 식 본문 생성자
    // public Car(string name) => this.name = name;

    public Tcar(string name) 
    {
        this.name = name; // this.필드(name) = 매개변수
    }

    public void Go() => Console.WriteLine($"[2] {name}가 달리다.");

}

class ConstructorDemo  
{
    static void Main(string[] args)
    {
        Tcar car = new Tcar(); 
        car.Go();

        Tcar my = new Tcar("좋은자동차");
        my.Go();

    }

}
