using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

class Solution
{
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