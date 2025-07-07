internal class Program
{
    private static void Main(string[] args)
    {
        ;
        Console.WriteLine(Solution070(100, 2));
    }

    public static int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }

    public static int Solution070(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }
}

