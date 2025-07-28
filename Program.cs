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
        var intArray = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        var strArr1 = new string[] { "we", "are", "the", "world" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        //Console.WriteLine(sol.SolutiSolution0725(10000));
        PrintIntArray(sol.SolutiSolution0728_2(strArr1));

        CS_study cS_Study = new CS_study();
        //cS_Study.ExceptionSample();

        // MakeLotto();

        int[] scores = { 80, 78, 60, 90, 100 };
        int sum = CalculateSum(scores);
        //Console.WriteLine(sum);
        
    }

    /// <summary>
    /// yeield
    /// </summary>
    /// <returns></returns>
    static IEnumerable<int> GetNumber()
    {
        yield return 10;
        yield return 20;
        yield return 30;
    }

    /// <summary>
    /// 정수 배열의 값을 더하는 함수
    /// </summary>
    /// <param name="scoresArray"></param>
    /// <returns></returns>
    public static int CalculateSum(int[] scoresArray)
    {
        int sum = 0;
        for (int i = 0; i < scoresArray.Length; i++)
        {
            sum += scoresArray[i];
        }

        return sum;
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

