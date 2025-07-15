using System.Formats.Asn1;
using System.Security.Cryptography;

internal class Program
{

    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArray = new int[] { 1 };
        Solution sol = new Solution();
        Console.WriteLine(sol.SolutiSolution0715_2("BCBdbe", "B"));
        // PrintIntArray(sol.SolutiSolution0715(intArray));
        
        CS_study cS_Study = new CS_study();
        //cS_Study.HashTableSample();

        // MakeLotto();
    }

    /// <summary>
    /// 정수 배열을 출력시키는 함수
    /// </summary>
    /// <param name="answerArray"></param>
    public static void PrintIntArray(int[] answerArray)
    {
        Console.Write("[");
        for (int i = 0; i < answerArray.Length; i++)
        {
            Console.Write(answerArray[i]);
            if (i != answerArray.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
    

    /// <summary>
    /// 로또
    /// </summary>
    public static void MakeLotto()
    {
        int TOTAL_BALLS = 45; // 전체 공 개수
        int PICK_BALLS = 6;   // 뽑는 공 수

        var rand = new Random();
        var ballList = new List<int>();

        for (int i = 1; i <= TOTAL_BALLS; i++)
        {
            ballList.Add(i);    // 리스트에 45까지 의 수를 1개씩 넣는다
        }

        for (int i = 0; i < PICK_BALLS; i++)
        {
            int index = rand.Next() % ballList.Count; // 랜덤 숫자

            Console.Write("[" + index + "]");
            Console.WriteLine(ballList[index]); // 랜덤한 숫자에 해당하는 리스트를 불러온다
            ballList.RemoveAt(index); // 랜덤 숫자의 리스트를 제거한다
        }

    }
}

