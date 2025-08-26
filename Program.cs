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
        var intArray = new int[] { 5,2,1,7,5 };
        var strArr1 = new string[] { "Bcad" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        //Console.WriteLine(sol.Solution0825(9,91));
        util.PrintArray(sol.Solution0826("banana"));
        //sol.Solution0806();

//12,4,15,46,38,-2,15 

        CS_study cS_Study = new CS_study();
        //cS_Study.TestMyArea();

        //util.sort(intArray, util.DescendingCompare);
        //util.PrintArray(intArray);

    }

    
}

