using System;

namespace Array_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //one-dimensional arrays
            sbyte[] arr = { 2, 66, 99, 127, -127, -22, 36 };
            foreach (var a in arr)
            {
                Console.WriteLine(a); ;
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Program.SortArr(arr);
            foreach (var a in arr)
            {
                Console.WriteLine(a); ;
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            int[] arr_1 = new int[10];
            foreach (var a in arr_1)
            {
                Console.WriteLine(a); ;
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Program.AddArr(arr_1);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Program.SortArr(arr_1);
            foreach (var a in arr_1)
            {
                Console.WriteLine(a); ;
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            //multi-dimensional arrays
            int[,] multyArr = new int[4, 3];
            Program.AddArr(multyArr);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            int[,] multyArr_1 = { { 1, 10, 13 }, { 23, 56, 14 }, { 19, 26, 79 }, { 89, 56, 23 } };
            for (int i = 0; i < multyArr_1.GetLength(0); i++)
            {
                for (int j = 0; j < multyArr_1.GetLength(1); j++)
                {
                    Console.WriteLine(multyArr_1[i, j]);
                }
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            //jagged arrays
            int[][] jaggedArr = { new int[3], new int[2], new int[5], new int[4] };
            Program.AddArr(jaggedArr);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            int[][] jaggedArr_1 = { new int[]{ 1 }, new int[] { 28, 46, 14 }, new int[] { 69, 86, 59, 61 }, new int[] { 119, 566, 234 } };
            for (int i = 0; i < jaggedArr_1.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArr_1[i].Length; j++)
                {
                    Console.WriteLine(jaggedArr_1[i] [j]);
                }
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }
        public static void AddArr(int[] arr)
        {
            Random rand = new Random(DateTime.Now.Second);
            for(int i = 0; i < arr.Length; i++)
            {                
                arr[i] = rand.Next(0, 100);
                Console.WriteLine(arr[i]);
            }
        }
        public static void AddArr(int[,] arr)
        {
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(100, 200);
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
        public static void AddArr(int[][] arr)
        {
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i] [j] = rand.Next(-50, 0);
                    Console.WriteLine(arr[i] [j]);
                }
            }
        }
        public static void SortArr<T>(T[] arr)
        {
            Array.Sort(arr);
        }             
    }
}
