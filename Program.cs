using System.Formats.Asn1;
using System.Security.Cryptography;

using jiwon;

internal class Program
{

    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArray = new int[] { 9, -1, 7, 5, 0 };
        var strArr1 = new string[] { "a", "b", "c" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution0806_2(999));
        //util.PrintIntArray(sol.SolutiSolution0804(10));
        //sol.Solution0806();

        CS_study cS_Study = new CS_study();
        //cS_Study.ParamSample();
        
    }

    
}

