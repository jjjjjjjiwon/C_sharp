using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Solution
{

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