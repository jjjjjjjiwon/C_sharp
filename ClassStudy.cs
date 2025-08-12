// base class
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

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