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
        var intArray = new int[] { 1,2,0,0,3 };
        var strArr1 = new string[] { "Bcad" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        //Console.WriteLine(sol.Solution0827_2(10));
        util.PrintArray(sol.Solution0827_2(10));
        //sol.Solution0806();

//12,4,15,46,38,-2,15 

        CS_study cS_Study = new CS_study();
        //cS_Study.TestMyArea();

        //util.sort(intArray, util.DescendingCompare);
        //util.PrintArray(intArray);

    }

    
}

