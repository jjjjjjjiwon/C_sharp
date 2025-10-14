using System.ComponentModel.DataAnnotations;

namespace jiwon
{
    class util
    {
        

        /// <summary>
        /// 내림 차순, 오름 차순
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public delegate int ComapreDelegate(int i1, int i2);
        public static void sort(int[] arr, ComapreDelegate comp)
        {
            if (arr.Length < 2) return;
            //Console.WriteLine($"Prototype : {comp.Method}");

            int ret;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    ret = comp(arr[i], arr[j]);
                    if (ret == -1)
                    {
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
            //PrintArray(arr);
        }
        // CompareDelegate와 동일한 prototype
        // 오름 차순
        public static int AscemdingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            return (i2 - i1) > 0 ? 1 : -1;
        }
        // CompareDelegate와 동일한 prototype
        // 내림 차순
        public static int DescendingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            return (i1 - i2) > 0 ? 1 : -1;
        }

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
    /// 제네릭 배열
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="answerArray"></param>
    public static void PrintArray<T>(T[] answerArray)
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