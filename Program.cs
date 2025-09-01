using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Security.Cryptography;

using jiwon;
using MyExtension; // 확장 메서드 용

internal class Program
{

    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArray = new int[] { 2, 1, 6, 5 };
        var strArr1 = new string[] { "Bcad" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        //Console.WriteLine(sol.Solution0829_2(4, 4, 4));
        //util.PrintArray(sol.Solution0829(intArray));
        //sol.Solution0806();
        sol.Solution0901();

        CS_study cS_Study = new CS_study();
        //cS_Study.TestMyArea();

        // 내림차순 정렬을 이용할 때
        //util.sort(intArray, util.DescendingCompare);
        //util.PrintArray(intArray);

       

    }

    
}

