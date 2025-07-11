using System.Collections;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Xml.Schema;

// var = 뒤의 것으로 변시, 숫자가 있으면 int, 문자열이 있으면 string
// var i = 1; - int형으로, var i = "ad"; - string으로

class CS_study
{

    /// <summary>
    /// ListSample
    /// List는 크기가 변할때 좋고
    /// 배열은 고정 되어 있을때 좋다
    /// </summary>
    public void ListSample()
    {
        //List<int> myList = new List<int>();
        var myList = new List<int>(); // int형 리스트
        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = myList[1]; // int형 밖에 안됨

        var chrList = new List<char>(); // char형 리스트
        chrList.Add('b');

        var boolList = new List<bool>(); // char형 리스트
        boolList.Add(false);

        //int[] iarray = new int[100];
        var iarray = new int[100];
        iarray[2] = 10;
        myList.Add(10); // List에 넣는 방법
        Console.WriteLine(iarray.Length); // 배열 길이 세는법
        Console.WriteLine(myList.Count); // List 길이 세는법 


        myList.Sort();
    }

    /// <summary>
    ///  ArrayList
    /// </summary>
    public void ArrayListSample()
    {
        // ArrayList myList = new ArrayList();
        var myList = new ArrayList(); // 위 아래 코드는 같다,

        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = (int)myList[1];

        Console.WriteLine(val);
        Console.WriteLine(myList[0]);
    }

    /// <summary>
    /// 
    /// </summary>
    public void ArraySample()
    {
        int sum = 0;
        //int [] nums = new int[10] {1,2,3,4,5,6,7,9,8,0}
        int[] nums = new int[10];

        nums[0] = 1;
        nums[1] = 2;
        //
        nums[9] = 0;
        // nums[10] = 0; - 배열의 크기를 넘어감

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
        }

        for (int i = 0; i < nums.Length; i += 1)
        {
            Console.WriteLine(i + " : " + nums[i]);
            sum += nums[i];
        }

        Console.WriteLine("sum = " + sum);


    }

    /// <summary>
    /// int, float, string은 기억하자
    /// </summary>
    public void DataType()
    {
        // bool 타입
        bool b = true;

        short sh = -32768;
        int i = 100;
        long l = 1234L;
        float f = 123.45f;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        Console.WriteLine(f);
        //sh = (short)i;
        i = (int)f;
        Console.WriteLine(i);

        char c = 'A';
        string s = "Hello_";
        string s2 = null;
        string s3 = ""; // "", string.Empty은 같은 빈 문자열을 의미
        string s4 = string.Empty; // 의도를 더 잘 나타내기 위해서는 string.Empty를 쓰자
        // int ii = null; - int는 null불가능 

        DateTime dt = new DateTime(2025, 7, 9, 11, 16, 00);

        Console.WriteLine(int.MaxValue); // 변수.MaxValue - 변수의 최대 값


    }

}