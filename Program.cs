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
        var intArray = new int[] { 9,10,11,8 };
        var strArr1 = new string[] { "Bcad" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution0819_2("heLLo"));
        //util.PrintArray(sol.Solution0819_2(strArr1));
        //sol.Solution0806();


        CS_study cS_Study = new CS_study();

        //CS_study.ILogger logger = new CS_study.ConsoleLogger();
        // CS_study.ILogger logger = new CS_study.FileLogger("MyText.Text");
        // // logger.WriteLog("Hello, world");
        // CS_study.ClimateMonitor monitor = new CS_study.ClimateMonitor(logger);
        // monitor.Start();

    }

    
}

