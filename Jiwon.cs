namespace jiwon
{
    class util
    {
        /// <summary>
        /// 사칙연산 계산기
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="calcType"></param>
        /// <returns></returns>
        /// <exception cref="ArithmeticException"></exception>
        public static int Calc(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return a / b;
                default:
                    throw new ArithmeticException();
            }
        }

        public void StructTest()
        {
            CS_study.MyPoint pt = new CS_study.MyPoint(10, 12);
            CS_study.MyPoint pt2 = new CS_study.MyPoint();
            Console.WriteLine(pt.ToString());
            Console.WriteLine(pt2.ToString());
        }

        /// <summary>
        /// yeield
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }

    /// <summary>
    /// 정수 배열의 값을 더하는 함수
    /// </summary>
    /// <param name="scoresArray"></param>
    /// <returns></returns>
    public static int CalculateSum(int[] scoresArray)
    {
        int sum = 0;
        for (int i = 0; i < scoresArray.Length; i++)
        {
            sum += scoresArray[i];
        }

        return sum;
    }


    /// <summary>
    /// 정수 배열을 출력시키는 함수
    /// </summary>
    /// <param name="answerArray"></param>
    public static void PrintIntArray(int[] answerArray)
    {
        Console.Write("[");
        for (int i = 0; i < answerArray.Length; i++)
        {
            Console.Write(answerArray[i]);
            if (i != answerArray.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
    

    /// <summary>
    /// 로또
    /// </summary>
    public static void MakeLotto()
    {
        int TOTAL_BALLS = 45; // 전체 공 개수
        int PICK_BALLS = 6;   // 뽑는 공 수

        var rand = new Random();
        var ballList = new List<int>();

        for (int i = 1; i <= TOTAL_BALLS; i++)
        {
            ballList.Add(i);    // 리스트에 45까지 의 수를 1개씩 넣는다
        }

        for (int i = 0; i < PICK_BALLS; i++)
        {
            int index = rand.Next() % ballList.Count; // 랜덤 숫자

            Console.Write("[" + index + "]");
            Console.WriteLine(ballList[index]); // 랜덤한 숫자에 해당하는 리스트를 불러온다
            ballList.RemoveAt(index); // 랜덤 숫자의 리스트를 제거한다
        }
    }

    }
}