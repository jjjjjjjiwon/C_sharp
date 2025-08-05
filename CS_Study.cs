using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using jiwon;

// var = 뒤의 것으로 변시, 숫자가 있으면 int, 문자열이 있으면 string
// var i = 1; - int형으로, var i = "ad"; - string으로


class  CS_study
{
    public void ParamSample()
    {
         // ref - 초기화 필요
        int x = 1;
        double y = 1.0;
        double ret = Getdata(ref x, ref y);
        Console.WriteLine($"x : {x}, y : {y}, ret : {ret}");
        //Console.WriteLine("x : {0}, y : {1}, ret : {2}", x,y,ret);

        // out - 초기화 불필요
        int c, d;
        bool bret = Getdata(10, 20, out c, out d);
        Console.WriteLine($"c : {c}, d : {d}, bret : {bret}");
        //Console.WriteLine("c : {0}, d : {1}, bret : {2}", c,d,bret);


        Method1(26, 100, "Park");
        Method1(name: "John", age: 10, score: 90);
        Method1(score: -20, name: "Lee", age: 30);
        Method1(2, 40); // 값을 넣어 두면 안줘도 됨
        Method1(score: 7, age: 10);

        Method2(100, 0, 44);
        Method2(99);

        Method3(44, 80, true);
        Method3();
        Method3(live: false);
        Method3(score: 100, age: 10);


        int ret2 = util.Calc(130, 7); // 기본으로 string에 "+"가 있어 생략하면 +연산
        ret2 = util.Calc(130, 7, "*");
        ret2 = util.Calc(b: 7, a: 130, calcType: "/"); // 알아서 적어도 됨
        Console.WriteLine(ret2);

        int s = Calc2(1, 2, 3, 4);
        //int s2 = Calc3(1, 2, 3, 4);
        int s2 = Calc2(6, 7, 8, 9, 0, 1); 
    
    }
    public int Calc3(int[] value)
    {
        return 0;
    }
    public int Calc2(params int[] value)
    {
        return 0;
    }
    public void Method3(int age = 10, int score = 0, bool live = true)
    {

    }
    public void Method2(int age, int score = 100, int city = 11)
    {

    }
    public void Method1(int age, int score, string name = "NoName")
    {

    }

    public double Getdata(ref int a, ref double b)
    {
        return ++a * ++b;
    }

    public bool Getdata(int a, int b, out int c, out int d)
    {
        c = a + b;
        d = a - b;
        return true;
    }

    public int Calulate(int a)
    {
        Console.WriteLine("a=" + a);
        a *= 2;
        Console.WriteLine("a=" + a);
        return a;
    }

    void NullableTest()
    {
        int? a = null;
        int? b = 0;
        int result = Nullable.Compare<int>(a, b);
        Console.WriteLine(result);

        double? c = 0.01;
        double? d = 0.0100;
        bool result2 = Nullable.Equals<double>(c, d);
        Console.WriteLine(result2);
    }

    double _Sum = 0;
    DateTime _Time;
    bool? _Selected;

    public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
    {
        if (i.HasValue && d.HasValue)
        {
            this._Sum = (double)i.Value + (double)d.Value;
        }
        if (!time.HasValue)
        {
            throw new ArgumentException();
        }
        else
        {
            this._Time = time.Value;
        }
        // 만약 selected가 null이면 false를 할당
        // if (selected == null)
        // {
        //     this._Selected = false;
        // }
        // else
        // {
        //     this._Selected = selected;
        // }
        this._Selected = selected ?? false;
    }

    // 구조체 정의
    public struct MyPoint
    {
        public int X;
        public int Y;

        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        public override string ToString()
        {
            return string.Format($"{X}, {Y}");
        }
    }




    /// <summary>
    /// try-catch-finally
    /// </summary>
    public void ExceptionSample()
    {
        int[] intArr = new int[3];
        try
        {
            intArr[5] = 0;
        }
        catch (AggregateException ex)
        {
            Console.WriteLine("AE ...");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("ior 오류 발생!" + ex);
        }
        finally
        {
            Console.WriteLine("에러 없음");
        }
    }

    /// <summary>
    /// Loop
    /// </summary>
    public void LoopSample()
    {
        // for
        for (int i = 0; i < 10; i += 3)
        {
            //Console.WriteLine($"Loop : {i}");
        }

        string[] array = new string[] { "AB", "CD", "EF" };
        foreach (var item in array)
        {
            //Console.WriteLine(item);
        }

        string[,,] arr = new string[,,]
        {
            {{"1", "2"}, {"11", "22"}},
            {{"3", "4"}, {"33", "44"}}
        };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    //Console.Write(arr[i, j, k] + ",");
                }
            }
        }
        //Console.WriteLine();
        foreach (var item in arr)
        {
            //Console.Write(item + ",");
        }

        // while
        int answer = 6;
        while (answer <= 10)
        {
            Console.Write(answer + ",");
            answer++;
        }

        Console.WriteLine();
        answer = 6;
        // do ~ while
        do
        {
            Console.Write(answer + ",");
            answer++;
        } while (answer <= 10);
    }

    /// <summary>
    /// switch
    /// </summary>
    public void conditionSample()
    {
        string category = "사과";
        int price = 0;

        switch (category)
        {
            case "사과":
            case "참외":
                price = 2000;
                break;
            case "딸기":
                price = 10000;
                break;
            case "포도":
                price = 6000;
                break;
            default:
                price = 1000;
                break;
        }
        Console.WriteLine($"{category}는 : {price}");
    }

    /// <summary>
    /// 연산자
    /// </summary>
    public void OperatiorSample()
    {
        int num = 1;
        int a = 0;
        int b = 0;
        Console.WriteLine($"before : {num}");
        num++;
        Console.WriteLine($"after : {num}");

        num = 2;
        num = num << 5;

        //int val = (a > b) ? a : b; // 삼항연산자
        int val;
        if (a > b)
        {
            val = a;
        }
        else
        {
            val = b;
        }

        string str = "aa"; // null
        string s = str ?? "몰라"; // str이 null이면 뒤 에 것을(몰라), 다른것이면 str의 값을 반환, null을 쓸수있는 것만 사용가능
        Console.WriteLine(s);
        int? ni = null; // int? - int에서 null을 사용하겠다는 뜻
        num = ni ?? 20;

    }

    string GetName() { return ""; }
    static public int GetId() { return 0; }
    public static int GetId2() { return 0; }

    public void CodingGuide()
    {
        bool isValid = false;
        if (isValid == false)
        {

        }
        else
        {

        }

        if (isValid)
        {

        }
        else
        {

        }

        string path = @"C:\Tmep\Test.txt";
        string s1 = "1", s2 = "2", s3 = "3";
        //var res = s1 + "+" + s2 + "=" + s3;
        var res = string.Format("{0} + {1} = {2}", s1, s2, s3);


    }

    public enum GameState { Ready, Run }
    public enum Category    // enum - 상수다,  클래스, namespace에서만 사용 가능하다, 메서드안에서는 못 쓴다, 형변환 가능
    {
        cake = 10,       // 아무것도 지정하지 않으면 초기값 0, 1, ,2로 증가
        IceCream,      // 윗 값에 +1 을 한다 5, 6, 7등으로
        Bread,          // 2, 1, ? 이런식으로 값을 지정하면 ?는 2번을 가리킨다
    }

    enum City
    {
        Seoul,
        Daejun,
        Busan = 5,
        Jeju = 10,
    }


    [Flags] // 비트연사을 하는
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8,
    }

    public void EnumSample()
    {
        Category cafeCategory;
        cafeCategory = Category.Bread;
        //Console.WriteLine((int)cafeCategory);
        City myCity = City.Seoul;
        int cityValue = (int)myCity;
        if (myCity == City.Seoul)
        {
            //Console.WriteLine("Welcome To Seoio")
        }

        // or 연산자로 다중 플래그 할당
        Border b = Border.Top | Border.Bottom | Border.Left; // Top, Bottom 두개 동시의
        // & 연산자로 플래그 체크
        if ((b & Border.Top) != 0)
        {
            // HasFlag() 이용
            if (b.HasFlag(Border.Bottom))
            {
                Console.WriteLine((int)b);
            }
        }
    }


    /// <summary>
    /// StringBulid
    /// </summary>
    public void SBSample()
    {
        var sb = new StringBuilder();
        for (int i = 1; i <= 26; i++)
        {
            sb.Append(i.ToString());    // Append - 문자열 또는 값을 추가
            //sb.Append(System.Environment.NewLine); // System.Environment.NewLine - 줄 바꿈, \n
            sb.Append(' ');
        }
        string s = sb.ToString();
        Console.WriteLine($"Result : {s}");

        sb.Clear();
        sb.Append('A' + 3);
        Console.WriteLine(sb.ToString());
    }


    /// <summary>
    /// char 을 string
    /// </summary>
    public void ASCIISample()
    {
        string s = "C# Studies";
        for (int i = 0; i < s.Length; i++)
        {
            //Console.WriteLine("{0}:{1}", i, s[i]);
        }

        string str = "Hello";
        char[] charArray = str.ToCharArray();  // ToCharArray - string를 char형 배열로 바꿔라
        for (int i = 0; i < charArray.Length; i++)
        {
            //Console.WriteLine("{0}:{1}", i, charArray[i]);
        }

        char[] charArray2 = { 'A', 'B', 'C', 'D' };
        string s2 = new string(charArray2);
        //Console.WriteLine(s2);

        // 문자 연산
        char c1 = 'A';
        char c2 = (char)(c1 + 3);
        Console.WriteLine(c2); // D




    }

    /// <summary>
    /// string.Substring
    /// </summary>
    public void StringSample()
    {
        string s1 = "C#";
        string s2 = "programming";
        int startIndex = 3;
        int len = s2.Length - startIndex - 1;
        string s3 = s2.Substring(startIndex, len);
        Console.WriteLine(s3);

        char c1 = 'A';
        char c2 = 'B';
        string s4 = s1 + " " + s2;
        Console.WriteLine("string : {0}", s4);

        string s4sub = s4.Substring(1, 5);
        Console.WriteLine("SubString : {0}", s4sub);
    }

    // var는 전역변수로 불가능
    // var a = new int();
    public void AArraySample()
    {
        // 중첩배열
        // 1차원 배열
        string[] player = new string[10];
        string[] regions = { "서울", "경기", "부산" };

        // 2차원 배열
        //string[,] depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };
        var depts = new string[,] { { "김과장", "경리부" }, { "이과장", "총무부" } };

        // 3차원 배열
        string[,,] cubes;

        // 가변 배열
        //int[,] aa = new int[3, 2];
        int[][] A = new int[3][];

        A[0] = new int[2];
        A[1] = new int[3] { 1, 2, 3 };
        A[2] = new int[4] { 1, 2, 3, 4 };

        A[0][0] = 1;
        A[0][1] = 2;

        //aa[0, 0] = 1;
        //aa[0, 1] = 1;

        int sum = 0;
        int[] scores = { 80, 78, 60, 90, 100 };

        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }

        Console.WriteLine($"sum = {sum}");

    }

    /// <summary>
    /// SortedDictionary - 정렬되는 dictionary
    /// </summary>
    public void SortedDicSample()
    {
        var tmap = new SortedDictionary<int, string>();
        tmap.Add(1001, "Tom");
        tmap.Add(1003, "John");
        tmap.Add(1010, "Irina");
        tmap.Add(1005, "Lee");

        string name1010 = tmap[1010];

        // Iterator
        foreach (KeyValuePair<int, string> kv in tmap)
        {
            Console.WriteLine("{0}:{1}:{0}", kv.Key, kv.Value);
        }
    }

    /// <summary>
    /// 해시테이블, 딕션어리
    /// </summary>
    public void HashTableSample()
    {
        // Hashtable

        Hashtable ht = new Hashtable();
        // var re = new Hashtable();
        ht.Add("Irina", "Irina Sp");
        ht.Add("tom", "Tom Cr");
        ht.Add(3, 'a');

        if (ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }

        //Dictionary

        //Dictionary<int, string> emp = new Dictionary<int, string>();
        var emp = new Dictionary<int, string>();
        emp.Add(1001, "jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");
        // if (emp.ContainsKey(1002) == false)
        // {
        //     emp.Add(1002, "kim");

        // }

        if (emp.ContainsValue("Cindy") == true)
        {
            Console.Write(emp);

        }

        String name = emp[1002];
        Console.WriteLine(name);
    }

    // <summary>
    /// 스택, Queue에 대한 것
    /// </summary>
    public void StackQueue()
    {
        // 스택
        // Stack<float> s = new Stack<float>();
        var s = new Stack<float>();
        s.Push(10.5f);  // push - 스택에 넣기
        s.Push(3.54f);
        s.Push(4.22f);

        float pp = s.Peek(); // peek - 미리 보기
        Console.WriteLine("pp = " + pp);    // 4.22

        // float p3 = s.Pop();
        var p3 = s.Pop();   // Pop - 스택 꺼내기 (꺼낸건 자료구조에서 삭제)
        Console.WriteLine("p3 = " + p3);    // 4.22

        var p4 = s.Pop();
        Console.WriteLine("p4 = " + p4);    // 3.54

        // Queue
        //Queue<int> q = new Queue<int>();
        var q = new Queue<int>();
        q.Enqueue(120); // Enqueue - Queue에 넣기
        q.Enqueue(130);
        q.Enqueue(150);

        int next = q.Peek();
        Console.WriteLine("next = " + next); // 120

        next = q.Dequeue(); // Dequeue - Queue 꺼내기
        Console.WriteLine("next = " + next);

        int next2 = q.Peek();
        Console.WriteLine("next = " + next2);


    }

    /// <summary>
    /// LinkedList에 대한 것
    /// </summary>
    public void LinkedListSample()
    {
        // LinkedList<string> list = new LinkedList<string>();
        var list = new LinkedList<string>();

        // var는 한줄에 하나만 정의 가능
        // var a = 1, var2 = 2;

        list.AddLast("Apple");
        list.AddLast("Banana");
        list.AddLast("Lemon");

        // LinkedListNode<string> node = list.Find("Banana");
        var node = list.Find("Banana");     // Find - 찾는 것
        var newNode = new LinkedListNode<string>("Grape");

        list.AddAfter(node, newNode);   // AddAfter - 노드 뒤에 붙이기
        list.AddAfter(node, "kiwi");    // AddAfter - (node, node) , (node, string value) 두가지 경우로 사용 가능

        list.ToList<string>().ForEach(p => Console.WriteLine(p));   // ToList - list를 List<string>로 변경 시키는 것, 인덱스 접근, 정렬, 반복등 사용 가능해짐

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

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