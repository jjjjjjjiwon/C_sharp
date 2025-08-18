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
        var intArray = new int[] { 5, 2, 1, 7, 5 };
        var strArr1 = new string[] { "a", "b", "c" };
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        Solution sol = new Solution();
        //Console.WriteLine(sol.Solution0814_2("cccCCC"));
        util.PrintArray(sol.Solution0818_2(24));
        //sol.Solution0806();


        CS_study cS_Study = new CS_study();
        //cS_Study.classSample();

        //CS_study.ILogger logger = new CS_study.ConsoleLogger();
        // CS_study.ILogger logger = new CS_study.FileLogger("MyText.Text");
        // // logger.WriteLog("Hello, world");
        // CS_study.ClimateMonitor monitor = new CS_study.ClimateMonitor(logger);
        // monitor.Start();

    }

    
}

