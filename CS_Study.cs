using System.Collections;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;

// var = 뒤의 것으로 변시, 숫자가 있으면 int, 문자열이 있으면 string
// var i = 1; - int형으로, var i = "ad"; - string으로

class CS_study
{

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