internal class Program
{

    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution0708(7, 2));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static int Solution0708(int num1, int num2)
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
    public static int Solution0707_2(int num1, int num2)
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
    public static int Solution0707(int num1, int num2)
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
    public static int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }


}

