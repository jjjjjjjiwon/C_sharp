﻿using System.Formats.Asn1;
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
        var intArray = new int[] { 4,2,6,1,7,6};
        var intArr2 = new int[] { 94, 777, 104, 1000, 1, 12 };
        var strArr1 = new string[] { "a", "b", "c", "d", "e", "f", "g"};
        var strArr2 = new string[] { "com", "b", "d", "p", "c" };
        var Arrbool = new bool[] { true, false, true, false };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution1014_2(10));
        //util.PrintArray(sol.Solution1013_2(strArr1));
        //sol.Solution0806();


        CS_study cS_Study = new CS_study();
        //cS_Study.FormatTest();
        
        // 내림차순 정렬을 이용할 때
        //util.sort(intArray, util.DescendingCompare);
        //util.PrintArray(intArray);



    }

    
}

