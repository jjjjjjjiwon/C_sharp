using System.Formats.Asn1;
using System.Linq.Expressions;
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
        var intArray = new int[] { 58,44,27,10,100 };
        var strArr1 = new string[] { "Bcad" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution0820_2(intArray, 139));
        //util.PrintArray(sol.Solution0819_2(strArr1));
        //sol.Solution0806();


        CS_study cS_Study = new CS_study();


        //util.sort(intArray, util.DescendingCompare);
        //util.PrintArray(intArray);

    }

    
}

