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
        var intArray = new int[] { 1,1,2,3,4,5};
        var strArr1 = new string[] { "a", "b", "c" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        Console.WriteLine(sol.SolutiSolution0731_2(intArray, 1));
        //util.PrintIntArray(sol.SolutiSolution0728_2(strArr1));

        CS_study cS_Study = new CS_study();
        //cS_Study.ExceptionSample();
    }

    
}

