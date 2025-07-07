internal class Program
{
    private static void Main(string[] args)
    {
        ;
        Console.WriteLine(Solution0707_2(27, 19));
    }


    public static int Solution0707_2(int num1, int num2)
    {
        int answer = 0;
        answer = num1 * num2;
        return answer;
    }

    public static int Solution0707(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }

    public static int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }


}

