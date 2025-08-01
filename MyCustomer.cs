using System.Security.Cryptography;

public class MyCustomer
{
    // 필드
    private string name;
    private int age;

    // 이벤트
    public event EventHandler NameChanged;

    // 생성자 (constructor)
    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }

    // 프로퍼티
    public string Name
    {
        get { return this.name; }
        set
        {
            this.name = value;
            if (NameChanged != null)
            {
                NameChanged(this, EventArgs.Empty);
            }
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value > 0)
            {
                this.age = value;
            }
            else
            {
                Console.WriteLine("음수값은 허용되지 않습니다.");
            }
        }
    }

    public void SetAge(int value)
    {
        if (value < 0)
        {
            Console.WriteLine("음수값은 허용되지 않습니다.");
        }
        else
        {
            age = value;
        }
    }

    // 메서드

    public String GetCustomerData()
    {
        //string data = string.Format("name:{0} age:{1}", Name, Age);
        string data = $"name:{Name} age:{Age}";
        return data;
    }

    public int CalAge(int val)
    {
        Age = Age - val;
        return Age;
    }

}