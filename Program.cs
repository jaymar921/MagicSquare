namespace CheckIfA2DArrayIsAMagicSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a 2D array is a magic square:\n (Enter your input, format: '[[n,n],[n,n]]')");

            while (true)
            {
                string input = "";

                for (int i = 0; i < 10; i++)
                {
                    string inP = Console.ReadLine().Trim().Replace(" ", "");

                    if (inP == "")
                    {
                        break;
                    }
                    if(inP.Contains("exit", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Program Exited.");
                        return;
                    }
                    input += inP;
                }

                int[][] arr = GetArray(input);

                // display the input
                Console.WriteLine("Input: \n[");
                for (int j = 0; j < arr.Length; j++)
                {
                    int[] a = arr[j];
                    Console.Write("   [");
                    for (int x = 0; x < a.Length; x++)
                    {
                        Console.Write(a[x].ToString().PadLeft(2) + ((x + 1 < a.Length) ? ", " : ""));
                    }
                    Console.Write("]" + ((j + 1 < arr.Length) ? ", " : "") + "\n");
                }

                Console.WriteLine("]");

                CheckMagicSquare(arr);
                Console.WriteLine("\nEnter your new input: ");
            }
        }

        public static void CheckMagicSquare(int[][] arr)
        {
            int sumRow = 0;
            int sumCol = 0;
            int sumDiagLR = 0;
            int sumDiagRL = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumRow = 0;
                sumCol = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    sumRow += arr[i][j];
                    sumCol += arr[j][i];
                }

                if (sumRow != sumCol)
                {
                    Console.WriteLine("\nNot a magic square");
                    return;
                }

                sumDiagLR += arr[i][i];
                sumDiagRL += arr[i][arr.Length - 1 - i];
            }

            if (sumDiagLR != sumDiagRL || sumDiagLR != sumRow)
            {
                Console.WriteLine("\nNot a magic square");
                return;
            }
            else
            {
                Console.WriteLine("\nIs a magic Square");
            }
        }

        public static int[][] GetArray(string input)
        {
            string[] arr = input.Replace("[[", "").Replace("]]", "").Split("],[");
            int[][] result = new int[arr.Length][];

            int x = 0;
            foreach (string s in arr)
            {
                string[] temp = s.Split(",");
                int[] arIn = new int[temp.Length];

                for (int i = 0; i < temp.Length; i++)
                {
                    arIn[i] = int.Parse(temp[i]);
                }

                result[x++] = arIn;
            }

            return result;
        }
    }
}
