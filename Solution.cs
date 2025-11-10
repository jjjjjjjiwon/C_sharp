using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Markup;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
using System.Windows;
using System.Diagnostics.Eventing.Reader;

class Solution
{
    /// <summary>
    /// qr code
    /// </summary>
    /// <param name="q"></param>
    /// <param name="r"></param>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution1110_2(int q, int r, string str)
    {
        string answer = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (i % q == r)
            {
                answer += str[i];
            }
        }
        
        // for (int i = r; i < str.Length; i += q)
        // {
        //     answer += str[i];
        // }

        return answer;
    }


    /// <summary>
    /// 수열과 구간 쿼리
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public int[] Solution1110(int[] arr, int[,] queries)
    {
        for (int q = 0; q < queries.GetLength(0); q++)
        {
            int start = queries[q, 0];
            int end = queries[q, 1];
            int k = queries[q, 2];

            for (int i = start; i <= end; i++)
            {
                if (i % k == 0)
                {
                    arr[i]++;
                }
            }
        }

        return arr;
    }

    /// <summary>
    /// 팩토리얼
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution1107(int n)
    {
        int answer = 1;
        int i = 1;

        while (answer < n)
        {
            i++;
            answer *= i;
        }

        return i - 1;
    }


    /// <summary>
    /// 가까운 수
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution1106(int[] arr, int n)
    {
        int answer = 0;
        int max = int.MaxValue;
        foreach (var item in arr)
        {
            int temp = (item > n) ? item - n : n - item;
            
            if (max > temp)
            {
                max = temp;
                answer = item;
            }
            else if (max == item)
            {
                answer = item;
            }
        }
        return answer;

    }
    
    /// <summary>
    /// 진료 순서 정하기
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int[] Solution1106(int[] arr)
    {
        var answer = new int[arr.Length];
        var list = new List<int>(arr);
        list.Sort();
        list.Reverse();

        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = list.IndexOf(arr[i]);
        }
        return answer;
    }


    /// <summary>
    /// 간단한 논리 연산
    /// </summary>
    /// <param name="x1"></param>
    /// <param name="x2"></param>
    /// <param name="x3"></param>
    /// <param name="x4"></param>
    /// <returns></returns>
    public bool Solution1105_2(bool x1,bool x2,bool x3,bool x4)
    {
        bool answer = (x1 | x2) & (x3 | x4);
        return answer;
    }

    /// <summary>
    /// 문자열 반복해서 출력하기
    /// </summary>
    public void Solution1105()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        string s1 = input[0];
        int a = Int32.Parse(input[1]);

        for (int i = 0; i < a; i++)
        {
            Console.Write(s1);
        }
    }
    

    public int Solution1104(int[] arr)
    {
        int answer = 0;

        var sb = new StringBuilder();
        foreach (var item in arr)
        {
            sb.Append(item);
        }
        string str = sb.ToString();

        foreach (var item in str)
        {
            if (item.Equals('7'))
            {
                answer++;
            }
        }

        return answer;
    }


    /// <summary>
    /// 한번만 등장하는 문자
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution1103(string str)
    {
        string answer = "";
        var dic = new Dictionary<char, int>();

        foreach (var item in str)
        {
            if (dic.TryGetValue(item, out int val))
            {
                dic[item]++;
            }
            else
            {
                dic.Add(item, 1);
            }
        }
        var list = new List<char>();

        foreach (var item in dic)
        {
            if (item.Value == 1)
            {
                list.Add(item.Key);
            }
        }

        list.Sort();

        foreach (var item in list)
        {
            answer += item;
        }

        return answer;
    }

    /// <summary>
    /// 세 개의 구분자
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string[] Solution1031(string str)
    {
        str = str.Replace("a", " ").Replace("b", " ").Replace("c", " ");
        string[] arrstr = str.Split(" ");
        var list = new List<string>();
        foreach (var item in arrstr)
        {
            if (item.Length > 0)
            {
                list.Add(item);
            }
        }
        if (list.Count == 0)
        {
            list.Add("EMPTY");
        }

        return list.ToArray();
    }

    /// <summary>
    /// k의 개수
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int Solution1030_2(int i, int j, int k)
    {
        int answer = 0;
        for (int idx = i; idx <= j; idx++)
        {
            string str = idx.ToString();
            foreach (var item in str)
            {
                int val = item - '0';
                if (val == k)
                {
                    answer++;
                }
            }
        }
        return answer;
    }    

    /// <summary>
    /// 2차원으로 만들기
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public int[,] Solution1030(int[] arr, int num)
    {
        int len = arr.Length / num;
        int[,] answer = new int[len, num];

        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < num; j++)
            {
                answer[i, j] = arr[i * num + j];
            }
        }
        
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                Console.Write(answer[i, j]);
            }
            Console.Write(",");
        }
            Console.WriteLine();

        return answer;
    }

    
    /// <summary>
    /// 모스부호
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution1029_2(string str)
    {
        Dictionary<string, char> morseDict = new Dictionary<string, char>()
        {
            [".-"] = 'A', ["-..."] = 'B', ["-.-."] = 'C', ["-.."] = 'D',
            ["."] = 'E', ["..-."] = 'F', ["--."] = 'G', ["...."] = 'H',
            [".."] = 'I', [".---"] = 'J', ["-.-"] = 'K', [".-.."] = 'L',
            ["--"] = 'M', ["-."] = 'N', ["---"] = 'O', [".--."] = 'P',
            ["--.-"] = 'Q', [".-."] = 'R', ["..."] = 'S', ["-"] = 'T',
            ["..-"] = 'U', ["...-"] = 'V', [".--"] = 'W', ["-..-"] = 'X',
            ["-.--"] = 'Y', ["--.."] = 'Z',
            ["-----"] = '0', [".----"] = '1', ["..---"] = '2',
            ["...--"] = '3', ["....-"] = '4', ["....."] = '5',
            ["-...."] = '6', ["--..."] = '7', ["---.."] = '8', ["----."] = '9'
        };

        // 단어 구분: "/" 또는 3칸 공백
        string[] words = str.Split(new[] { " / ", "   " }, StringSplitOptions.None);
        List<string> decodedWords = new List<string>();

        foreach (string word in words)
        {
            string[] letters = word.Split(' ');
            string decodedWord = "";

            foreach (string letter in letters)
            {
                if (morseDict.TryGetValue(letter, out char ch))
                    decodedWord += ch;
                else if (!string.IsNullOrWhiteSpace(letter))
                    decodedWord += '?'; // 알 수 없는 부호
            }

            decodedWords.Add(decodedWord);
        }

        return string.Join(" ", decodedWords);

    }

    /// <summary>
    /// A로 B만들기
    /// </summary>
    /// <param name="be"></param>
    /// <param name="af"></param>
    /// <returns></returns>
    public int Solution1029(string be, string af)
    {
        foreach (var item in af)
        {
        int idx = be.IndexOf(item);
        if (idx < 0)
        {
            return 0;
        }
        else
        {
            be = be.Remove(idx, 1);
        }    
        }
        

        return 1;
    }


    /// <summary>
    /// 문자열이 몇 번 등장하는지 세기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="pat"></param>
    /// <returns></returns>
    public int Solution1027_2(string str, string pat)
{
    int count = 0;

    // str 길이만큼 반복
    for (int i = 0; i <= str.Length - pat.Length; i++)  // i가 pat의 길이만큼 길어지지 않도록
    {
        // str[i..i+pat.Length]가 pat과 일치하면 count 증가
        if (str.Substring(i, pat.Length) == pat)
        {
            count++;
        }
    }

    return count;
}




    /// <summary>
    /// 특정 문자열로 끝나는 가장 긴 부분 문자열 찾기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="pat"></param>
    /// <returns></returns>
    public string Solution1027(string str, string pat)
    {
        string answer = string.Empty;
        int idx = str.LastIndexOf(pat);
        answer = str.Substring(0, idx + pat.Length);
        return answer;
    }

    /// <summary>
    /// 문자열 뒤집기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="s"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public string Solution1024_2(string str, int s, int e)
    {
        char[] chr = str.ToCharArray();
        Array.Reverse(chr, s, e - s + 1);
        return new string(chr);
    }

    /// <summary>
    /// 1로 만들기
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int Solution1024(int[] num_list)
    {
        int answer = 0;
        foreach (var num in num_list)
        {
            int item = num;
            while (item > 1)
            {
                if (item % 2 == 0)
                {
                    item /= 2;
                }
                else
                {
                    item = (item - 1) / 2;
                }
                answer++;
            }
        }

        return answer;
    }

    /// <summary>
    /// 배열 만들기 5
    /// </summary>
    /// <param name="arrStr"></param>
    /// <param name="k"></param>
    /// <param name="s"></param>
    /// <param name="l"></param>
    /// <returns></returns>
    public int[] Solution1023_2(string[] arrStr, int k, int s, int l)
    {
        var list = new List<int>();

        foreach (var item in arrStr)
        {
            string str = item.Substring(s, l);
            int istr = Convert.ToInt32(str);

            if (istr > k)
            {
                list.Add(istr);
            }
        }

        return list.ToArray();
    }


    /// <summary>
    /// 글자 지우기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="arr"></param>
    /// <returns></returns>
    public string Solution1023(string str, int[] arr)
    {
        var sb = new StringBuilder();
        var list = new List<int>(arr);
        for (int i = 0; i < str.Length; i++)
        {
            if (!list.Contains(i))
            {   
                sb.Append(str[i]);
            }
        }
        return sb.ToString();

    }

    /// <summary>
    /// 빈 배열에 추가, 삭제함
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    // public int[] Solution1022_2(int[] arr, bool[] flag)
    // {
    //     Stack<int> st = new Stack<int>();
    //     st.Push(1);
    //     st.Push(2);
    //     st.Push(3);
    //     int[] aaa = st.ToArray();
    //     Array.Reverse(aaa);
    // }
    
    /// <summary>
    /// 수열과 구간 쿼리
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[] Solution1022(int[] arr,int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = array[i,0]; i <= array[i,1]; j++)
            {
                arr[j]++;
            }
        }
        return arr;
    }


    /// <summary>
    /// 합성수 찾기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution1021_2(int n)
    {
        int answer = 0;
        for (int i = 4; i <= n; i++)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    answer++;
                    break;
                }
            }
        }

        return answer;
    }
    
    /// <summary>
    /// 중복된 문자 제거
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution1021(string str)
    {
        string answer = string.Empty;
        foreach (var item in str)
        {
            if (!answer.Contains(item))
            {
                answer += item;
            }
        }    
        return answer;
    }

    /// <summary>
    /// 날짜 비교하기
    /// </summary>
    /// <param name="array"></param>
    /// <param name="array2"></param>
    /// <returns></returns>
    public int Solution1020_2(int[] array, int[] array2)
    {
        const int YEAR = 0;
        const int MONTH = 1;
        const int DAY = 2;
        int answer = 0;

        // 그냥 if
        // if (array[YEAR] < array2[YEAR])
        // {
        //     answer = 1;
        // }
        // else if (array[YEAR] == array2[YEAR])
        // {
        //     if (array[MONTH] < array2[MONTH])
        //     {
        //         answer = 1;
        //     }
        //     else if (array[MONTH] == array2[MONTH])
        //     {
        //         if (array[DAY] < array2[DAY])
        //         {
        //             answer = 1;
        //         }
        //         else{}

        //     }
        // }

        // 날짜로
        // DateTime dt1 = new DateTime(array[YEAR], array[MONTH], array[DAY]);
        // DateTime dt2 = new DateTime(array2[YEAR], array2[MONTH], array2[DAY]);
        // answer = dt1 < dt2 ? 1 : 0;

        // 문자로 변화하고 다시 숫자로
        int dt1 = Convert.ToInt32($"{array[YEAR]}{array[MONTH]}{array[DAY]}");
        int dt2 = Convert.ToInt32($"{array2[YEAR]}{array2[MONTH]}{array2[DAY]}");
        answer = dt1 < dt2 ? 1 : 0;

        return answer;
    }

    /// <summary>
    /// 등차수열의 특정한 항만 더하기
    /// </summary>
    /// <param name="a"></param>
    /// <param name="d"></param>
    /// <param name="include"></param>
    /// <returns></returns>
    public int Solution1020(int a, int d, bool[] include)
    {
        int answer = 0;
        for (int i = 0; i < include.Length; i++)
        {
            if (include[i])
            {
                answer += i * d + a;
            }
        }
        return answer;
    }

    public string Solution1017_2(string str, string str2)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            sb.Append(str[i]);
            sb.Append(str2[i]);
        }
        return sb.ToString();
    }

    /// <summary>
    /// 이차원 배열 대각선 순회하기
    /// </summary>
    /// <param name="board"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int Solution1017(int[,] board, int k)
    {
        int answer = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (i + j <= k)
                {
                    answer += board[i, j];
                }
            }
        }
        return answer;
        
    }


    /// <summary>
    /// 문자열 잘라서 정렬하기
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string[] Solution1016_2(string str)
    {
        string[] parts = str.Split("x");
        var list = new List<string>();
        foreach (var item in parts)
        {
            if (item.Length > 0)
            {
                list.Add(item);
            }
        }
        list.Sort();
        return list.ToArray();
    }


    /// <summary>
    /// 세로 읽기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="n"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public string Solution1016(string str, int n, int c)
    {
        int nu2 = n;
        var list = new List<char>();
        for (int i = 0; i < str.Length; i += n)
        {
            string substring = str.Substring(i, Math.Min(n, str.Length - i));

            if (substring.Length >= c)
            {
                list.Add(substring[c - 1]);
            }
        }

        return new string(list.ToArray());
    }

    /// <summary>
    /// 369게임
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int Solution1015_2(int num)
    {
        string str = num.ToString();
        int counter = 0;

        foreach (var item in str)
        {
            if (item == '3' || item == '3' || item == '9')
                counter++;
        }
        return counter;
    }

    /// <summary>
    /// 배열 회전시키기
    /// </summary>
    /// <param name="array"></param>
    /// <param name="str"></param>
    /// <returns></returns>
    public int[] Solution1015(int[] array, string str)
    {
        List<int> list = new List<int>(array);
        switch (str)
        {
            case "right":
                int last = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, last);
                break;
            case "left":
                int first = list[0];
                list.RemoveAt(0);
                list.Add(first);
                break;

            default:
                break;
        }

        return list.ToArray();
    }

    /// <summary>
    /// 피자 나눠 먹기 2
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int Solution1014_2(int num)
    {
        int count = 1;

         while ((6 * count) % num != 0)
        {
            count++;
        }

        return count;
    }

    /// <summary>
    /// 외계행성의 나이
    /// </summary>
    /// <param name="age"></param>
    /// <returns></returns>
    public string Solution1014(int age)
    {
        var result = new List<char>();

        if (age >= 100)
        {
            int a100 = age / 100;
            result.Add((char)(a100 + 'a'));
        }

        if (age >= 10)
        {
            int a10 = (age / 10) % 10;
            result.Add((char)(a10 + 'a'));
        }

        int a1 = age % 10;
        result.Add((char)(a1 + 'a'));

        return new string(result.ToArray());
    }

    /// <summary>
    /// 5명씩
    /// </summary>
    /// <param name="Arraystr"></param>
    /// <returns></returns>
    public string[] Solution1013_2(string[] Arraystr)
    {
        int count = 1;
        var list = new List<string>();

        foreach (var item in Arraystr)
        {
            if (count == 1 || count % 5 == 1)
            {
                list.Add(item);
            }
            count++;
        }
        return list.ToArray();

    }

    /// <summary>
    /// A 강조하기
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution1013(string str)
    {
        string answer = string.Empty;
        foreach (var item in str)
        {
            if (item == 'a' || item == 'A')
            {
                answer += item.ToString().ToUpper();
            }
            else
            {
                answer += item.ToString().ToLower();
            }
        }
        return answer;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public int Solution1010_2(string str)
    {
        int answer = 0;

        foreach (var item in str)
        {
            answer += item - '0';
        }
        return answer % 9;
    }
    /// <summary>
    /// n개 간격의 원소들
    /// </summary>
    /// <param name="array"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public int[] Solution1010(int[] array, int num)
    {
        var list = new List<int>();
        for (int i = 0; i < array.Length; i = +num)
        {
            list.Add(array[i]);
        }
        return list.ToArray();
    }

    /// <summary>
    /// 할일 목록
    /// </summary>
    /// <param name="Arrstr"></param>
    /// <param name="Arrbool"></param>
    /// <returns></returns>
    public string[] Solution1002_2(string[] Arrstr, bool[] Arrbool)
    {
        var list = new List<string>();
        for (int i = 0; i < Arrstr.Length; i++)
        {
            if (Arrbool[i] == false)
            {
                list.Add(Arrstr[i]);
            }
        }
        return list.ToArray();
    }

    /// <summary>
    /// 조건에 맞게 수열 변환하기 1
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int[] Solution1002(int[] arr)
    {
        var list = new List<int>();
        foreach (var item in arr)
        {
            list.Add(item >= 50 ? (item % 2 == 0 ? item / 2 : item) : (item % 2 == 1 ? item * 2 : item));
        }
        return list.ToArray();
    }


    /// <summary>
    /// 길이에 따른 연산
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int Solution1001(int[] arr)
    {
        int answer = 0;
        int answer2 = 1;
        foreach (var item in arr)
        {
            answer += item;
            answer2 *= item;
        }
        return arr.Length > 10 ? answer : answer2;
    }

    /// <summary>
    /// 가까운 1찾기
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="idx"></param>
    /// <returns></returns>
    public int Solution0930_2(int[] arr, int idx)
    {
        int num = 0;
        foreach (var item in arr)
        {
            num++;
            if (num > idx && item == 1)
            {
                return num - 1;
            }
        }
        return -1;
    }

    /// <summary>
    /// 원하는 문자열 찾기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="pat"></param>
    /// <returns></returns>
    public int Solution0930(string str, string pat)
    {
        return str.ToLower().Contains(pat.ToLower()) ? 1 : 0;
    }

    /// <summary>
    /// 원소들의 곱과 합
    /// 
    /// </summary>
    /// <param name="iarry"></param>
    /// <returns></returns>
    public int Solution0929_2(int[] iarry)
    {
        int gop = 1;
        int hap = 0;
        foreach (var item in iarry)
        {
            gop *= item;
            hap += item;
        }
        hap = hap * hap;

        return (hap > gop) ? 0 : 1;
    }

    /// <summary>
    /// 접미사인지 확인
    /// </summary>
    /// <param name="str"></param>
    /// <param name="istr"></param>
    /// <returns></returns>
    public int Solution0929(string str, string istr)
    {
        bool ox = str.EndsWith(istr);

        return ox ? (int)1 : (int)0;
    }

    /// <summary>
    /// 홀짝에 따라 다른 값 반환하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0926_2(int n)
    {
        int answer = 0;
        if (n % 2 == 1)
        {
            for (int i = 1; i <= n; i += 2)
            {
                if (n % 2 == 1)
                {
                    answer += i;
                }
            }
        }
        else
        {
            for (int i = 2; i <= n; i += 2)
            {
                if (n % 2 == 0)
                {
                    answer += i * i;
                }
            }
        }

        return answer;
    }

    /// <summary>
    /// 두 수의 연산값 비교하기
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Solution0926(int a, int b)
    {
        int num2 = 10 * b.ToString().Length;
        int num1 = a * num2;

        return ((num1 + b) > (2 * a * b)) ? num1 + b : 2 * a * b;
    }

    /// <summary>
    /// st 부터 end까지
    /// </summary>
    /// <param name="st"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public int[] Solution0925_2(int st, int end)
    {
        int len = end - st + 1;
        int[] answer = new int[len];

        for (int i = 0; i < len; i++)
        {
            answer[i] = st + i;
        }

        return answer;
    }

    /// <summary>
    /// 모든 문자를 대문자로
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution0925(string str)
    {
        return str.ToUpper();
    }

    /// <summary>
    /// 모든 문자를 소문자로
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution0924_2(string str)
    {
        return str.ToLower();
    }

    /// <summary>
    /// 간다한 식 계산하기
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public int Solution0924(string str)
    {
        int answer = 0;
        string[] sa = str.Split();
        int a = Convert.ToInt32(sa[0]);
        int b = int.Parse(sa[2]);

        // switch (sa[1])
        // {
        //     case "+":
        //         answer = a + b;
        //         break;
        //     case "-":
        //         answer = a - b;
        //         break;
        //     case "*":
        //         answer = a * b;
        //         break;
        //     default:
        //         break;
        // }

        answer = sa[1] switch
        {
            "+" => a + b,
            "-" => a + b,
            "*" => a + b,
        };

        return answer;
    }

    public string[] Solution0922(string str)
    {
        string[] strArr = str.Split();
        var list = new List<string>();
        foreach (var item in strArr)
        {
            //if (item != "")
            //if (item != string.Empty)
            if (!item.Equals(string.Empty))
            {
                list.Add(item);
            }
        }
        return list.ToArray();
    }

    /// <summary>
    /// 홀수 짝수
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int Solution0919_2(int[] array)
    {
        int answer1 = 0;
        int answer2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                answer1 += array[i];
            }
            else
            {
                answer2 += array[i];
            }
        }
        return (answer1 < answer2) ? answer2 : answer1;
    }

    /// <summary>
    /// X사이의 개수
    /// </summary>
    /// <param name="myString"></param>
    /// <returns></returns>
    public int[] Solution0919(string myString)
    {
        string[] str = myString.Split('x');
        int[] answer = new int[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            answer[i] = str[i].Length;
        }
        return answer;
    }

    /// <summary>
    /// 정렬하고 앞 5개 제외 지우기
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int[] Solution0915_2(int[] arr)
    {
        List<int> lis = new List<int>(arr);

        lis.Sort();

        lis.RemoveRange(5, lis.Count - 5);

        return lis.ToArray();

    }

    /// <summary>
    /// 숫자 문자열을 정수형으로
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public int Solution0915(string str)
    {
        //return int.Parse(str);
        return Convert.ToInt32(str);
    }

    /// <summary>
    /// 정렬해서 아래 5개를 지워라
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int[] Solution0912_2(int[] num)
    {
        List<int> lis = new List<int>(num);

        lis.Sort();

        lis.RemoveRange(0, 5);


        return lis.ToArray();
    }

    /// <summary>
    /// 문자열을 하나식 더하라
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public int Solution0912(string str)
    {
        int answer = 0;
        foreach (var item in str)
        {
            answer += item - '0';
        }
        return answer;
    }

    /// <summary>
    /// 수를 문자열로
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string Solution0911_2(int n)
    {
        //return n.ToString();
        //return "" + n;
        //return string.Format("{0}", n);
        return new string($"{n}");
    }

    /// <summary>
    /// 문자열이 포함되어 있나
    /// </summary>
    /// <param name="str"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public int Solution0911(string str, string str2)
    {
        // int answer = 0;
        // if (str.Contains(str2)) answer = 1;
        // return answer;

        //return str.Contains(str2) ? 1 : 0;
        return str.IndexOf(str2) < 0 ? 0 : 1;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int Solution0910_2(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] != arr[j, i])
                {
                    return 0;
                }
            }
        }
        return 1;
    }

    /// <summary>
    /// 2차원 배열, 같은 수만 1
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[,] Solution0910(int n)
    {
        // int[,] answer = new int[n,n];
        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         if (i == j)
        //         {
        //             answer[i, j] = 1;
        //         }
        //     }
        // }
        // return answer;

        int[,] answer = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
        }
        return answer;
    }

    /// <summary>
    /// 앞에0이면 없에라
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution0909_2(string str)
    {
        // bool isZero = true;
        // while (isZero)
        // {
        //     //if (str[0].CompareTo('0') == 0)
        //     if (str[0].Equals('0'))
        //     {
        //         str = str.Substring(1);
        //     }
        //     else
        //     {
        //         isZero = false;
        //     }
        // }
        // return str;
        return Convert.ToInt32(str).ToString();
    }


    /// <summary>
    /// 부분 문자열
    /// </summary>
    /// <param name="str"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public int Solution0909(string str, string str2)
    {
        return str2.Contains(str) ? 1 : 0;
    }

    public string Solution0908_2(string[] str_list, string str)
    {
        // string answer = "";
        // foreach (var item in str_list)
        // {
        //     if (!item.Contains(str))
        //     {
        //         answer += item;
        //     }
        // }
        // return answer;

        var sb = new StringBuilder();
        foreach (var item in str_list)
        {
            if (!item.Contains(str))
            {
                sb.Append(item);
            }
        }
        return sb.ToString();
    }

    /// <summary>
    /// 배열의 원소 삭제하기
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public int[] Solution0908(int[] arr, int[] arr2)
    {
        var answer = new List<int>();
        foreach (var item in arr)
        {
            if (!arr2.Contains(item))
            {
                answer.Add(item);
            }
        }

        return answer.ToArray();
    }

    /// <summary>
    /// 정수 찾기
    /// </summary>
    /// <param name="num"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0905_2(int[] num, int n)
    {
        // int answer = 0;
        // foreach (var item in num)
        // {
        //     if (item == n)
        //     {
        //         return answer = 1;
        //     }
        // }
        // return answer;

        return num.Contains(n) ? 1 : 0;
    }


    /// <summary>
    /// 문자열 바꿔서 찾기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="pat"></param>
    /// <returns></returns>
    public int Solution0905(string str, string pat)
    {
        // string st = string.Empty;
        // foreach (var item in st)
        // {
        //     st += item.Equals('A') ? "B" : "A";
        // }
        // return st.Contains(pat) ? 1 : 0;

        string st = string.Empty;

        st = str.Replace('A', 'b').Replace('B', 'a').ToUpper();
        return st.Contains(pat) ? 1 : 0;

    }


    /// <summary>
    /// 정수의 위치 찾기
    /// </summary>
    /// <param name="num"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int Solution0904_2(int num, int k)
    {
        // int answer = num.ToString().IndexOf(k.ToString());
        // return (answer == -1) ? answer : answer + 1;

        // 복잡하게
        string str = num.ToString();
        char kchr = (char)('0' + k); // k를 char형태로 만들기 위해

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Equals(kchr))
            {
                return i + 1;
            }
        }
        return -1;

    }

    /// <summary>
    /// 정수 부분
    /// </summary>
    /// <param name="flo"></param>
    /// <returns></returns>
    public int Solution0904(double flo)
    {
        int answer = 0;
        // answer = (int)flo;
        // return answer;

        // 복잡하게
        string str = flo.ToString();
        string[] strArr = str.Split(".");
        answer = Convert.ToInt32(strArr[0]); //convert대신 parse써도 됨

        return answer;
    }

    /// <summary>
    /// 조건에 맞게 수열 변환
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public int[] Solution0903_2(int[] arr, int num)
    {
        int[] answer = new int[arr.Length];
        bool usEven = num % 2 == 0;
        for (int i = 0; i < arr.Length; i++)
        {
            answer[i] = usEven ? arr[i] + num : arr[i] * num;
        }
        return answer;
    }

    /// <summary>
    /// l앞의 영어를 l로 교체
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string Solution0903(string str)
    {
        string answer = string.Empty;
        foreach (var item in str)
        {
            if (item < 'l')
            {
                answer += 'l';
            }
            else
            {
                answer += item;
            }
        }
        return answer;

        //return Regex.Replace(str, "[a-k]", "l");
    }

    /// <summary>
    /// 이어 붙인 수
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int Solution0902_2(int[] num)
    {
        int answer = 0;
        string even = "", odd = "";

        foreach (var item in num)
        {
            if (item % 2 == 0)
            {
                even += item;
            }
            else
            {
                odd += item;
            }
        }
        return answer = Int32.Parse(even) + Convert.ToInt32(odd);
    }

    /// <summary>
    /// 특정 문자를 대문자로 바꾸기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public string Solution0902(string str, string str2)
    {
        //return str.Replace(str2, str2.ToUpper());

        string answer = string.Empty;
        foreach (var item in str)
        {
            if (item.ToString().Equals(str2))
            {
                answer += str2.ToUpper();
            }
            else
            {
                answer += item;
            }
        }
        return answer;
    }

    public void Solution0901_2()
    {
        string[] s;
        Console.Clear();
        s = Console.ReadLine().Split();
        int a = Int32.Parse(s[0]);
        int b = Convert.ToInt32(s[1]);

        Console.WriteLine("{0} + {1} + {2}", a, b, a + b);
    }

    /// <summary>
    /// 문자열 시계방향으로 90돌리기
    /// </summary>
    public void Solution0901()
    {
        string s;
        Console.Clear();
        s = Console.ReadLine();
        foreach (var item in s)
        {
            Console.WriteLine(item);
        }
    }


    public int Solution0829_2(int a, int b, int c)
    {
        int answer = 0;
        if (a == b && a == c)
        {
            answer = (a + b + c) * (a * a + b * b + c * c) * (a * a * a + b * b * b + c * c * c);
        }
        else if (a != b && a != c && b != c)
        {
            answer = a + b + c;
        }
        else
        {
            answer = (a + b + c) * (a * a + b * b + c * c);
        }

        return answer;
    }

    /// <summary>
    /// 마직막 인덱스를 
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0829(int[] num_list)
    {
        int Len = num_list.Length;
        List<int> answer = new List<int>();

        foreach (var item in num_list)
        {
            answer.Add(item);
        }

        int lastIndex = Len - 1;
        int result = num_list[lastIndex] > num_list[lastIndex - 1]
            ? num_list[lastIndex] - num_list[lastIndex - 1]
            : num_list[lastIndex] * 2;

        answer.Add(result);

        return answer.ToArray();
    }

    /// <summary>
    /// 변하게 만든 값을 찾아라
    /// </summary>
    /// <param name="arry"></param>
    /// <returns></returns>
    public string Solution0828_2(int[] arry)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < arry.Length - 1; i++)
        {
            int val = arry[i + 1] - arry[i];
            if (val == 1) sb.Append('w');
            else if (val == -1) sb.Append('s');
            else if (val == 10) sb.Append('d');
            else sb.Append('a');

        }
        return sb.ToString();
    }

    /// <summary>
    /// wasd에 맞게 동작하라
    /// </summary>
    /// <param name="n"></param>
    /// <param name="control"></param>
    /// <returns></returns>
    public int Solution0828(int n, string control)
    {
        int answer = n;
        foreach (var item in control)
        {
            if (item == 'w') answer += 1;
            if (item == 'a') answer -= 10;
            if (item == 's') answer -= 1;
            if (item == 'd') answer += 10;
        }

        return answer;
    }

    /// <summary>
    /// 콜라츠 추측
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0827_2(int n)
    {
        List<int> list = new List<int>();
        while (true)
        {
            list.Add(n);

            if (n == 1)
            {
                break;
            }
            else if (n % 2 != 0)
            {
                n = n * 3 + 1;
            }

            else if (n % 2 == 0)
            {
                n = n / 2;
            }
        }

        return list.ToArray();
    }

    /// <summary>
    /// 문자열의 인덱스를 배열의 값으로 뽑아 문자열을 만드는
    /// </summary>
    /// <param name="str"></param>
    /// <param name="index_List"></param>
    /// <returns></returns>
    public string Solution0827(string str, int[] index_List)
    {
        // stringBuilder로
        var sb = new StringBuilder();
        foreach (var item in index_List)
        {
            sb.Append(str[item]);
        }

        return sb.ToString();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string[] Solution0826(string str)
    {
        var list = new List<string>();
        for (int i = 0; i < str.Length; i++)
        {
            list.Add(str.Substring(i));
        }
        list.Sort();
        return list.ToArray();
    }

    /// <summary>
    /// 두개의 수를 나열해 가장 큰수를
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Solution0825(int a, int b)
    {
        string ab = $"{a}{b}";
        string ba = $"{b}{a}";
        int iab = int.Parse(ab);
        int iba = Convert.ToInt32(ba);
        int answer = Math.Max(iab, iba);
        return answer;
    }

    /// <summary>
    /// n보다 작은 k의 배수
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] Solution0822_2(int n, int k)
    {
        var answer = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (i * k > n) break;
            answer.Add(i * k);

        }

        return answer.ToArray();
    }

    /// <summary>
    /// num에서 end 까지 1씩 감소하는
    /// </summary>
    /// <param name="num"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public int[] Solution0822(int num, int end)
    {
        // int len = num - end + 1;
        // int[] answer = new int[len];
        // for (int i = 0; i < len; i++)
        // {
        //     answer[i] = num - 1;
        // }
        // return answer;

        //List로
        var list = new List<int>();
        for (int i = num; i >= end; i--)
        {
            list.Add(i);
        }
        return list.ToArray();
    }

    /// <summary>
    /// 인덱스 n뒤의 값을 앞으로
    /// </summary>
    /// <param name="num"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0821_2(int[] num, int n)
    {
        int[] answer = new int[num.Length];
        int idx = 0;
        for (int i = n; i < num.Length; i++)
        {
            answer[idx] = num[i];
            idx++;
        }
        for (int i = 0; i < n; i++)
        {
            answer[idx] = num[i];
            idx++;
        }

        return answer;
    }

    /// <summary>
    /// 배열에 음수가 나올때의 인덱스 찾기
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int Solution0821(int[] num)
    {
        int answer = 0;

        foreach (var item in num)
        {
            if (item > 0)
            {
                answer++;
                if (num.Length == answer)
                {
                    answer = -1;
                }

            }
            else if (item < 0)
            {
                break;
            }

        }

        return answer;
    }

    /// <summary>
    /// n보다 클때까지 배열의 값을 더하라
    /// </summary>
    /// <param name="number"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0820_2(int[] number, int n)
    {
        int answer = 0;

        foreach (var item in number)
        {
            answer += item;
            if (answer > n)
            {
                break;
            }
        }
        return answer;
    }

    /// <summary>
    /// 문자열 뒤에서 n번째부터 읽기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public string Solution0820(string str, int n)
    {
        //return str.Substring(str.Length - n, n);
        //return str.Remove(0, str.Length - n);

        string answer = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (i < str.Length - n)
            {
                continue;
            }
            else
            {
                answer += str[i];
            }
        }
        return answer;

    }

    /// <summary>
    /// 문자열 소문자로 하고 오름차순
    /// </summary>
    /// <param name="result"></param>
    /// <returns></returns>
    public string Solution0819_2(string result)
    {
        // string answer = result.ToLower();
        // var list = new List<char>(answer);
        // list.Sort();
        // answer = new string(list.ToArray());
        // return answer;

        char[] chrarr = result.ToLower().ToCharArray();
        Array.Sort(chrarr);
        return new string(chrarr);

    }

    /// <summary>
    /// 배열에 큰값 , 인덱스
    /// </summary>
    /// <param name="arry"></param>
    /// <returns></returns>
    public int[] Solution0819(int[] arry)
    {
        int[] answer = new int[2];

        var dic = new Dictionary<int, int>();
        for (int i = 0; i < arry.Length; i++)
        {
            dic.Add(arry[i], i);
        }
        var list = new List<int>(arry);
        list.Sort();
        answer[0] = list[list.Count - 1];
        answer[1] = dic[answer[0]];
        return answer;
    }

    /// <summary>
    /// 약수를 찾아 오름차순으로 정렬
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0818_2(int n)
    {
        List<int> list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }

    /// <summary>
    /// 인덱스 바꾸기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string Solution0818(string str, int num1, int num2)
    {
        string answer = string.Empty;
        char chr1 = str[num1];
        char chr2 = str[num2];
        for (int i = 0; i < str.Length; i++)
        {
            if (i == num1)
            {
                answer += chr2;
            }
            else if (i == num2)
            {
                answer += chr1;
            }
            else
            {
                answer += str[i];
            }
        }

        return answer;
    }


    public string Solution0814_2(string str)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var ch in str)
        {
            if (ch >= 'a' && ch <= 'z')
                sb.Append(char.ToUpper(ch));
            else if (ch >= 'A' && ch <= 'Z')
                sb.Append(char.ToLower(ch));
            else
                sb.Append(ch);
        }
        return sb.ToString();
    }

    /// <summary>
    /// true면 더하고, flase면 빼라
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    public int Solution0814(int a, int b, bool flag)
    {
        int answer = 0;

        // if (flag)
        // {
        //     answer = a + b;
        // }
        // else
        // {
        //     answer = a - b;
        // }
        // return answer;

        // if를 삼항으로
        return answer = flag ? a + b : a - b;
    }

    /// <summary>
    /// n번째 마다 띄어 읽기
    /// </summary>
    /// <param name="str"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public string Solution0813_2(string str, int n)
    {
        string answer = " ";
        for (int i = n - 1; i < str.Length; i += n)
        {
            answer += str[i];
        }
        return answer;
    }

    /// <summary>
    /// n 번째 원소부터
    /// </summary>
    /// <param name="num_list"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0813(int[] num_list, int n)
    {
        int len = num_list.Length - n + 1;
        int[] answer = new int[len];
        // for (int i = 0; i < len; i++)
        // {
        //     answer[i] = num_list[n - 1 + i];
        // }
        // num_list의 크기만큼 반복
        for (int i = n - 1, j = 0; i < num_list.Length; i++, j++)
        {
            answer[j] = num_list[i];
        }
        return answer;
    }

    /// <summary>
    /// 홀수 인지 짝수 인지
    /// </summary>
    public void Solution0812_2()
    {
        string[] s;
        // Console.Clear();55
        s = Console.ReadLine().Split(' ');
        int a = Int32.Parse(s[0]);
        const string str = "{0} is {1}";
        const string strEven = "even";
        const string strOdd = "odd";
        string strVal = (a % 2 == 0) ? strEven : strOdd;
        Console.WriteLine(str, a, strVal);
        // if (a % 2 == 1)
        // {
        //     Console.Write($"{a} is odd");
        // }
        // else
        //     Console.Write($"{a} is even");
    }

    /// <summary>
    /// 문자열문자열문자열
    /// </summary>
    /// <param name="my_String"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public string Solution0812(string my_String, int k)
    {
        // string answer = "";
        var sb = new StringBuilder();
        for (int i = 0; i < k; i++)
        {
            //answer += my_String;
            sb.Append(my_String);
        }

        return sb.ToString();
    }

    /// <summary>
    /// 배열에 있는 가장 큰 두수의 곱
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int Solution0811_2(int[] numbers)
    {
        int answer = 0;

        Array.Sort(numbers);
        answer = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
        if (answer < numbers[0] * numbers[1])
        {
            answer = numbers[0] * numbers[1];
        }

        return answer;
    }

    /// <summary>
    /// 문자열 자연수의 합
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public int Solution0811(string my_string)
    {
        int answer = 0;
        foreach (var item in my_string)
        {
            if ((item >= '1') && (item <= '9'))
            {
                answer += (item - '0');
            }
        }

        return answer;
    }

    /// <summary>
    /// 문자열 안에 수를 찾아 오름차순 정렬
    /// </summary>
    /// <param name="st"></param>
    /// <returns></returns>
    public int[] Solution0808_2(string st)
    {
        var list = new List<int>();

        foreach (var item in st)
        {
            if (item >= '0' && item <= '9')
            {
                list.Add(item - '0');
            }
        }
        list.Sort();

        return list.ToArray();
    }

    /// <summary>
    /// 상자안에 주사위 개수
    /// </summary>
    /// <param name="IsBoxed"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0808(int[] IsBoxed, int n)
    {
        int answer = 1;

        answer *= IsBoxed[0] / n;
        answer *= IsBoxed[1] / n;
        answer *= IsBoxed[2] / n;

        return answer;
    }

    /// <summary>
    /// 가위 바위 보, 무조건 이기는
    /// </summary>
    /// <param name="rsp"></param>
    /// <returns></returns>
    public string Solution0807_2(string rsp)
    {
        string answer = string.Empty;
        foreach (var item in rsp)
        {
            if (item == '0')
            {
                answer += "5";
            }
            else if (item == '2')
            {
                answer += "0";
            }
            else if (item == '5')
            {
                answer += "2";
            }
        }
        return answer;
    }

    /// <summary>
    /// 공배수 인가
    /// </summary>
    /// <param name="number"></param>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public int Solution0807(int number, int n, int m)
    {
        int answer = 0;
        if (number % n == 0 && number % m == 0)
        {
            answer = 1;
        }

        return answer;
    }

    /// <summary>
    /// 가장적은 병사의 수
    /// </summary>
    /// <param name="hp"></param>
    /// <returns></returns>
    public int Solution0806_2(int hp)
    {
        int generaLlAP = 5;
        int soldierAP = 3;
        int WorkerAP = 1;
        int answer = 0;

        int generaLlAcount = hp / generaLlAP;
        hp = hp % generaLlAP;
        int soldierAcount = hp / soldierAP;
        hp = hp % soldierAP;
        answer = generaLlAcount + soldierAcount + hp;

        return answer;
    }


    /// <summary>
    /// 별로 직각 삼각형 만들기
    /// </summary>
    public void Solution0806()
    {
        string[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');
        int n = Int32.Parse(s[0]);

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    /// <summary>
    /// 할인율
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public int SolutiSolution0804_2(int price)
    {
        double answer = price;

        if (price >= 500000)
        {
            answer = price * 0.80;
        }
        else if (price >= 300000)
        {
            answer = price * 0.90;
        }
        else if (price >= 100000)
        {
            answer = price * 0.95;
        }

        return (int)answer;
    }


    /// <summary>
    /// 숫자를 포함한 아래 수의 홀수 찾기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] SolutiSolution0804(int n)
    {
        var list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                list.Add(i);
            }
        }

        return list.ToArray();
    }

    /// <summary>
    /// 베열의 중간은?
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int SolutiSolution0801_2(int[] num)
    {

        List<int> LIst = new List<int>(num);
        LIst.Sort();

        int answer = LIst.Count / 2;

        return LIst[answer];
    }

    /// <summary>
    /// 배열 2배 만들기
    /// </summary>
    /// <param name="iArry"></param>
    /// <returns></returns>
    public int[] SolutiSolution0801(int[] iArry)
    {

        for (int i = 0; i < iArry.Length; i++)
        {
            iArry[i] *= 2;
        }

        return iArry;
    }

    public int SolutiSolution0731_2(int[] iArry, int num)
    {
        int answer = 0;

        foreach (var item in iArry)
        {
            if (item == num)
                answer++;
        }

        return answer;
    }


    /// <summary>
    /// 문자열 붙여서 출력하기
    /// </summary>
    public void SolutiSolution0731()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        string s1 = input[0];
        string s2 = input[1];


        Console.Write(s1 + s2);

    }

    /// <summary>
    /// 제곱수 판별
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int SolutiSolution0730_2(int num)
    {
        int answer = 0;
        int min = 1, max = 1000;

        // for (int i = min; i <= max; i++)
        // {
        //     if (i * i == num)
        //     {
        //         answer = 1;
        //         break;
        //     }
        //     answer = 2;
        // }

        // 루트
        // if (Math.Sqrt(num) == (int)Math.Sqrt(num))
        //     answer = 1;
        // else answer = 2;
        // answer = (Math.Sqrt(num) == (int)Math.Sqrt(num)) ? 1 : 2; // 삼항으로

        return answer;
    }

    /// <summary>
    /// 문자열 배열 모두 합치기
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string SolutiSolution0730(string[] str)
    {
        string answer = " ";

        // foreach (var item in str)
        // {
        //     answer += item;
        // }

        // stringbuilder
        // var sb = new StringBuilder();
        // foreach (var item in str)
        // {
        //     sb.Append(item);
        // }
        // answer = sb.ToString();

        return answer;
    }

    /// <summary>
    /// 문자열을 각 자리를 n번 만큼 반복하라
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public string SolutiSolution0729_2(string my_string, int n)
    {
        string answer = string.Empty;

        foreach (var item in my_string)
        {
            for (int i = 0; i < n; i++)
            {
                answer += item;
            }
        }
        return answer;
    }

    // 문자열안에 문자열이 있는가
    public int SolutiSolution0729(string str, string str2)
    {
        int answer = 0;

        if (str.Contains(str2)) // contain 문자열안에 비교할 것이 있는지 확인하는
        {
            answer = 1;
        }
        else
        {
            answer = 2;
        }

        //int answer = str.Contains(str2) ? 1 : 2; // 삼항으로도 가능

        return answer;
    }

    // 문자열 배열 안에 있는 문자열의 크기
    public int[] SolutiSolution0728_2(string[] strlist)
    {
        int length = strlist.Length;
        int[] answer = new int[length];

        for (int i = 0; i < length; i++)
        {
            answer[i] = strlist[i].Length;
        }

        return answer;
    }

    /// <summary>
    /// 개수와 남은 돈
    /// </summary>
    /// <param name="money"></param>
    /// <returns></returns>
    public int[] SolutiSolution0728(int money)
    {
        // int[] answer = new int[2];
        // answer[0] = money / 5500;
        // answer[1] = money % 5500;
        //return answer;
        return new int[] { money / 5500, money % 5500 };
    }

    /// <summary>
    /// 배열에서의 기준값의 배수를 찾기
    /// </summary>
    /// <param name="num"></param>
    /// <param name="iArry"></param>
    /// <returns></returns>
    public int[] SolutiSolution0725_2(int num, int[] iArry)
    {
        var list = new List<int>();

        foreach (var item in iArry)
        {
            if (item % num == 0)
            {
                list.Add(item);
            }
        }

        int[] answer = new int[list.Count];

        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = list[i];
        }

        return answer;
    }

    /// <summary>
    /// 약수
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SolutiSolution0725(int n)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                answer++;
        }

        return answer;
    }

    /// <summary>
    /// 두 문자열의 같은 계수
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public int SolutiSolution0724_2(string[] s1, string[] s2)
    {
        int answer = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            for (int k = 0; k < s2.Length; k++)
            {
                if (s1[i] == s2[k])
                    answer++;
            }
        }
        return answer;
    }

    /// <summary>
    /// 몇 사분면에 있는가
    /// </summary>
    /// <param name="dot"></param>
    /// <returns></returns>
    public int SolutiSolution0724(int[] dot)
    {
        int answer = dot[0] > 0 ? dot[1] > 0 ? 1 : 4 : dot[1] > 0 ? 2 : 3;
        return answer;
    }

    /// <summary>
    /// 사람 수와 피자 한 판당 조각 수를 받아서 필요한 피자 판 수를 계산합니다.
    /// </summary>
    /// <param name="slice">한 판에 들어있는 피자 조각 수</param>
    /// <param name="n">피자를 먹을 사람 수</param>
    /// <returns>필요한 피자 판 수</returns>
    public int SolutiSolution0723_2(int slice, int n)
    {
        int answer = n / slice;      // 몫
        if (n % slice != 0)         // 나머지가 있으면 소수가 있는 것 → +1
        {
            answer += 1;
        }

        return answer;
    }

    /// <summary>
    /// num1 ~ num2 사이의 배열의 수 찾기
    /// </summary>
    /// <param name="array"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int[] SolutiSolution0723(int[] array, int num1, int num2)
    {
        int length = num2 - num1 + 1;
        int[] answer = new int[length];

        for (int i = 0; i < length; i++)
        {
            answer[i] = array[num1 + i];
        }

        return answer;
    }

    /// <summary>
    /// 삼각형이 가능한가?
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int SolutiSolution0722_2(int[] array)
    {
        int answer = 0;
        // list를 이용한 정렬
        var list = new List<int>(array);
        list.Sort();
        answer = (list[2] < list[1] + list[0]) ? 1 : 2;

        /// 그냥
        //Array.Sort(array);
        // if (array[array.Length - 1] >= array[array.Length - 2] + array[array.Length - 3])
        // {
        //     answer = 2;
        // }
        // else
        // {
        //     answer = 1;
        // }

        // return (array[2] < array[1] + array[0]) ? 1 : 2; // 삼항 연산자로//
        return answer;
    }


    /// <summary>
    /// 나보다 큰 키는 몇명?
    /// </summary>
    /// <param name="array"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public int SolutiSolution0722(int[] array, int height)
    {
        int answer = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > height)
            {
                answer++;
            }
        }
        return answer;
    }

    /// <summary>
    /// 각 자리수 더하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SolutiSolution0721_2(int n)
    {
        int answer = 0;
        string str = n.ToString();
        foreach (var item in str)
        {

            answer += item - '0';
        }

        return answer;
    }

    /// <summary>
    /// 영어 모음 빼기
    /// </summary>
    /// <param name="my_String"></param>
    /// <returns></returns>
    public string SolutiSolution0721(string my_String)
    {
        // foreach 사용
        //    string answer = string.Empty;
        //     foreach (var item in my_String)
        //     {
        //         if ((item != 'o') && (item != 'a') && (item != 'e') && (item != 'i') && (item != 'u'))
        //         {
        //             answer += item;  // String연산이니까, stringBulider를 쓰자
        //         }
        //     }

        // String. 사용
        // my_String.Replace('a','\0'); 도 가능
        string answer = my_String.Replace("a", "");
        answer = answer.Replace("e", "");
        answer = answer.Replace("i", "");
        answer = answer.Replace("o", "");
        answer = answer.Replace("u", "");
        //return my_String.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", ""); 이런 식으로 도 가능하다

        return answer;
    }


    /// <summary>
    /// 배열의 가장 큰수 2개 곱하기
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int SolutiSolution0718(int[] numbers)
    {
        int answer = 0;


        // 중첩 반복문
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     for (int j = 0; j < numbers.Length; j++)
        //     {
        //         if (i != j)
        //         {
        //             continue;
        //         }

        //         // if (answer < numbers[i] * numbers[j])
        //         // {
        //         //     answer = numbers[i] * numbers[j];
        //         // }

        //         answer = Math.Max(answer, numbers[i] * numbers[j]); // 두개 중에 뭐가 더 큰 값인지
        //     }
        // }


        // 오르차순으로 정리해서 마지막수 두개의 곱
        Array.Sort(numbers);
        answer = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];

        return answer;
    }

    /// <summary>
    /// 제곱은?
    /// </summary>
    /// <param name="n"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public int SolutiSolution0717_2(int n, int t)
    {
        int answer = 0;

        answer = n * (int)Math.Pow(2, t);

        return answer;
    }

    /// <summary>
    /// 피자 나누기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SolutiSolution0717(int n)
    {

        int answer = 0;

        // int piz = n / 7;
        //int res = (n / 7 == 0) ? 0 : 1; // 삼항 연산자

        // if (n % 7 == 0)
        // {
        //     res = 0;
        // }
        // else
        // {
        //     res = 1;
        // }

        //answer = piz + res;

        answer = (n - 1) / 7 + 1;

        return answer;
    }

    /// <summary>
    /// 문자열 뒤집기
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string SolutiSolution0716_2(string my_string)
    {
        // 기본적인
        // int len = my_string.Length;
        // char[] answerArray = new char[len];
        // for (int i = 0; i < len; i++)
        // {
        //     // 위치를 주의해서 배열로 바꾼 answer에 넣자
        //     answerArray[len - i - 1] = my_string[i];
        // }

        // // 캐릭터 배열을 스트링으로 바꿔서 리턴
        // string answer = new string(answerArray);
        // stringBuilder 사용
        // var sb = new StringBuilder();
        // foreach (var item in my_string)
        // {
        //     sb.Insert(0, item);    
        // }
        // string answer = sb.ToString();

        // List로
        // 스트링 > 리스트 > 배열 > 스트링
        var list = new List<char>(my_string);
        list.Reverse();
        string answer = new string(list.ToArray());

        return answer;
    }

    /// <summary>
    /// 편지
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public int SolutiSolution0716(string message)
    {
        int answer = 0;
        answer = message.Length * 2;

        return answer;
    }

    /// <summary>
    /// 특정문자 제거
    /// </summary>
    /// <param name="myst"></param>
    /// <param name="letter"></param>
    /// <returns></returns>
    public string SolutiSolution0715_2(string myst, string letter)
    {
        string answer = string.Empty;

        answer = myst.Replace(letter, string.Empty);

        //StringBuilder
        // var sb = new StringBuilder();
        // foreach (var item in myst)
        // {
        //     if (item.ToString().CompareTo(letter) != 0)
        //     {
        //         sb.Append(item);
        //     }
        // }
        // answer = sb.ToString();

        // foreach (var item in myst)
        // {
        //     if (item.ToString() != letter)
        //     {
        //         answer += item;
        //     }
        // }

        return answer;
    }

    /// <summary>
    /// 짝수의 개수, 홀수의 개수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] SolutiSolution0715(int[] num_list)
    {
        var answer = new int[2] { 0, 0 };

        foreach (var item in num_list)
        {
            if (item % 2 == 0)
            {
                answer[0]++;
            }
            else
            {
                answer[1]++;
            }



            // answer[item % 2]++;  // 신박하네
        }

        return answer;
    }


    /// <summary>
    ///  배열 뒤집기
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] SolutiSolution0714_2(int[] num_list)
    {
        int len = num_list.Length;
        int[] answer = new int[len];

        for (int i = 0; i < len; i++)
        {
            // answer[len - 1 - i] = num_list[i];
            answer[i] = num_list[len - 1 - i];
        }


        return answer;
    }

    /// <summary>
    ///  배열의 평균 값
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public double Solution0714(int[] numbers)
    {
        double answer = 0;

        // foreach문
        foreach (var item in numbers)
        {
            answer += item;
        }

        // for문
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     answer += numbers[i];
        // }

        answer /= numbers.Length;

        return answer;
    }

    /// <summary>
    /// 짝수 더하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0711_2(int n)
    {
        int answer = 0;

        if (0 < n && n <= 1000)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    answer += i;
                }
            }
        }

        return answer;
    }

    /// <summary>
    ///  계산
    /// </summary>
    /// <param name="d">양꼬치</param>
    /// <param name="k">음료수</param>
    /// <returns></returns>
    public int Solution0711(int n, int k)
    {
        int answer = 0;
        int num = n / 10;

        answer = (n * 12000) + ((k - num) * 2000);

        return answer;
    }

    /// <summary>
    /// 각도
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0710_2(int num1)
    {
        int answer = 3;
        string str = "둔";
        Console.Write(num1 + "도는 ");
        if (num1 == 180)
        {
            answer = 4;
            str = "평";
        }

        else if (num1 == 90)
        {
            answer = 2;
            str = "직";
        }
        if ((0 < num1) && (num1 < 90))
        {
            answer = 1;
            str = "예";
        }
        // else
        // {
        //     answer = 3;
        //     str = "둔";
        // }

        Console.WriteLine(str + "각입니다");

        return answer;
    }

    /// <summary>
    ///  더하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0710(int num1, int num2)
    {
        return num1 + num2;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0709_2(int num1, int num2)
    {
        int answer = 0;

        // answer = (int)(((float)num1 / (float)num2) * 1000);

        return (int)(((float)num1 / (float)num2) * 1000);
    }

    /// <summary>
    /// 나이 구하기_2022
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0709(int age)
    {
        int answer = 0;
        answer = 2022 - age + 1;
        return answer;
    }

    /// <summary>
    /// 숫자 비교하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0708_2(int num1, int num2)
    {
        // int answer;
        if (num1 == num2)
        {
            return 1;
        }
        return -1;

        // return answer;
    }

    /// <summary>
    ///  나누기 연산
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0708(int num1, int num2)
    {
        int answer = 0;
        answer = num1 / num2;
        return answer;
    }

    /// <summary>
    /// 두 수의 곱하기 연산
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0707_2(int num1, int num2)
    {
        int answer = 0;
        answer = num1 * num2;
        return answer;
    }

    /// <summary>
    /// 빼기 연산
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0707(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }

    /// <summary>
    /// 나머지 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }

}