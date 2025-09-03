// base class
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

partial class Class1
{
    public void Run() { }
}

partial class Class1
{
    public void Get() { }
}

partial class Class1
{
    public void Put() { }
}

partial struct struct1
{
    public int ID;
}

partial struct struct1
{
    public string Name;
    public struct1(int id, string name)
    {
        this.ID = id;
        this.Name = name;
    }
}

partial interface IDoable
{
    string Name { get; set; }
}

partial interface IDoable
{
    void Do();
}

public class DoClass : IDoable
{
    public string Name { get; set; }

    public void Do()
    {

    }
}

public static class MyUtility
{
    private static int ver;

    static MyUtility()
    {
        ver = 1;
    }

    public static string convert(int i)
    {
        return i.ToString();
    }

    public static int convertBack(string s)
    {
        return int.Parse(s);
    }


}

public class MyClass
{
    int val = 1;

    public MyClass()
    {
        val = 100;
    }

    public int InstRun()
    {
        return val;
    }

    // static 메서드
    public static int Run()
    {
        return 1;
    }
}

public class Client
{
    public void Test()
    {
        // 일반 메서드 호출
        MyClass myClass = new MyClass();
        int i = myClass.InstRun();
        Console.WriteLine($"i: {i}");

        // static
        int j = MyClass.Run();
        Console.WriteLine($"j: {j}");
    }
}


public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    protected int weight { get; set; }
    private int Gold;
    public void SetGold(int value)
    {
        Gold = value;
    }
    private int GetGold()
    {
        return Gold;
    }
}

// child class
public class Dog : Animal
{
    public void Setweight(int value)
    {
        weight = value;
    }
    public void HowOld()
    {
        // base class Age
        Console.WriteLine($"Age : {this.Age}, weight : {this.weight}");
    }

}

public class Bird : Animal
{
    public void FLy()
    {
        Console.WriteLine($"{this.Name} is flying");
    }
}

public abstract class PureBase
{
    public abstract int GetFirst();
    public abstract int GetNext();

    public int GetEnd()
    {
        return 100;
    }
}

public class DerivedA : PureBase
{
    private int no = 1;

    // override
    public override int GetFirst()
    {
        throw new NotImplementedException();
    }
    public override int GetNext()
    {
        return no++;
    }
}