// 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는
// 클래스의 속성을 나타내는 멤버

using System;

class PropertyDemo
{
    private string name;
    public string Name;
    public string Name4 { get; set; } = "My Name4 ";

    public string GetName()
    {
        return name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }

    static void Main()
    {
        PropertyDemo pd = new PropertyDemo();
        pd.Name = "My Name";
        Console.WriteLine(pd.Name);

        pd.SetName("My PD");
        Console.WriteLine(pd.GetName()); 

        PropertyDemo pd2 = new PropertyDemo() { Name = "My Car" };
        Console.WriteLine(pd2.Name);

        // 속성(접근지정자) 없이 호출
        var person = new { Name3 = "Red", Age = 21 };
        Console.WriteLine(person.Name3);
        Console.WriteLine(person.Age);

        PropertyDemo Mname = new PropertyDemo { Name4 = null };
        Console.WriteLine(Mname.Name4);
        var namet = Mname?.Name4;
        Console.WriteLine(namet);
        namet =  Mname?.Name4 ?? "대포차";
        Console.WriteLine(namet);
    }
}
