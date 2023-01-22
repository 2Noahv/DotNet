class Car33
{
    // params 배열형으로 받음
    public void Map2(params string[] title)
    {
        foreach (var t in title)
        {
            System.Console.WriteLine(t);
        }
    }

    
    public void Map(out string title2)
    {
        title2 = "참조반환";
    }
}
