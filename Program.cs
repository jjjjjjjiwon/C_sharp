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
        var intArray = new int[] { 0, -31, 24, 10, 1, 9 };
        var strArr1 = new string[] { "a", "b", "c" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        //Console.WriteLine(sol.Solution0812("string", 3));
        //util.PrintIntArray(sol.Solution0808_2("hi12392"));
        //sol.Solution0806();
        sol.Solution0812_2();


        CS_study cS_Study = new CS_study();
        //cS_Study.classSample();
        //cS_Study.preProTest();



    }

    
}

