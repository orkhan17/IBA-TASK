using System;

namespace IBA_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            int dir = 0;
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m:");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Direction and Enter 1 or 2");
            Console.WriteLine("1 - L->R");
            Console.WriteLine("2 - R->L");
            dir = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array");
            string[,] a = new string[n,m];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i,j] = Console.ReadLine();
                }
            }

            Console.WriteLine("---------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------");
            Console.WriteLine("Answer");

            if (dir == 1)
                Console.WriteLine(LToR(a, n ,m));
            if (dir == 2)
                Console.WriteLine(RToL(a, n, m));
        }

        static string LToR(string[,] a, int n, int m)
        {
            string ans = "";
            int[] arr = new int[2*m];
            for (int i = 0; i < n * m; i++)
            {
                arr[i % m] = i % m;
                arr[2 * m - 1 - (i%m)] = arr[i % m];

                ans += a[i / m, arr[i % (2*m)]] + " ";
            }

            return ans;
        }

        static string RToL(string[,] a, int n, int m)
        {
            string ans = "";
            int[] arr = new int[2 * m];
            for (int i = 0; i < n * m; i++)
            {
                arr[i % m] = m - 1 - (i % m);
                arr[2 * m - 1 - (i % m)] = arr[i % m];

                ans += a[i / m, arr[i % (2 * m)]] + " ";
            }

            return ans;
        }
    }
}
