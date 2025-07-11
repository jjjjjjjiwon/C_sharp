using System.Security.Cryptography;

internal class Program
{

    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        //Console.WriteLine(sol.Solution0711_2(4));

        CS_study cS_Study = new CS_study();
        //cS_Study.ListSample();

        MakeLotto();
    }

    /// <summary>
    /// 로또
    /// </summary>
    public static void MakeLotto()
    {
        var rand = new Random();
        var ballList = new List<int>();

        for (int i = 1; i <= 45; i++)
        {
            ballList.Add(i);    // 리스트에 45까지 의 수를 1개씩 넣는다
        }

        for (int i = 0; i < 6; i++)
        {
            int index = rand.Next() % ballList.Count; // 랜덤 숫자

            Console.Write("[" + index + "]");   
            Console.WriteLine(ballList[index]); // 랜덤한 숫자에 해당하는 리스트를 불러온다
            ballList.RemoveAt(index); // 랜덤 숫자의 리스트를 제거한다
        }





    }
}

