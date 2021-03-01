using System;
using System.Text;
using System.Text.RegularExpressions;

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

            //string
            string str = "Salut";
            Console.WriteLine(str);
            var str_1 = "Noroc";
            Console.WriteLine(str_1);            
            var str_2 = str.Substring(2);            
            Console.WriteLine(str_2);
            var str_3 = str.Replace('t', 'd');
            Console.WriteLine(str_3);
            Console.WriteLine(str);
            var str_4 = String.Concat(str, str_1);
            Console.WriteLine(str_4);
            var str_5 = str_4.Insert(5, " ");
            Console.WriteLine(str_5);
            var str_6 = str_5.Split(' ');
            foreach(var a in str_6)
                Console.WriteLine(a);
            var str_7 = String.Join(" ", str_6);
            Console.WriteLine(str_7);
            
            //stringbuilder
            StringBuilder stringBuilder = new StringBuilder("Hello");
            Console.WriteLine(stringBuilder);
            stringBuilder.Append("my friend");
            Console.WriteLine(stringBuilder);
            stringBuilder.Insert(5, " ");
            Console.WriteLine(stringBuilder);

            //advansed HW
            
            // 1.
            var str_cons = Console.ReadLine();
            var str_cons_1 = str_cons.ToCharArray();
            Array.Reverse(str_cons_1);
            var str_cons_2 = String.Join("", str_cons_1);
            Console.WriteLine(str_cons_2);
            
            // 2.
            var str_cons_3 = new StringBuilder(); 
            int key, count = 0;
            while ((key = Console.Read()) != 13)
            {
                if (++count > 20)
                    break;                 
                str_cons_3.Append((char)key);
            }
            if (str_cons_3.Length < 20)
            {
                int length = str_cons_3.Length;
                for (int j = 0; j < 20 - length; j++)
                    str_cons_3.Append("*");                
            }
            else
                Console.WriteLine("This string has 20 characters");
            Console.WriteLine(str_cons_3);
            Console.In.Close();

            // 3.
            var str_sons_4 = "We are living in a yellow submarine. We don't have anything else." +
                " Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            var countSubString = new Regex("in").Matches(str_sons_4).Count;
            Console.WriteLine(countSubString);
            
            var builderStr_Cons_4 = str_sons_4;
            string substring = "in";
            var countSubString_1 = 0;           
            while (builderStr_Cons_4.Length > 0)
            {
                var j = builderStr_Cons_4.IndexOf(substring);                
                if (j >= 0)
                {
                    countSubString_1++;
                    builderStr_Cons_4 = builderStr_Cons_4.Remove(0, j + substring.Length);
                }
                else
                    break;                
            }
            Console.WriteLine(countSubString_1);

            // 4.
            int[] arr4 = new int[20];
            AddArr4(arr4);

            // 5.
            int[] arr5 = new int[4];
            int[] arr6 = new int[4];
            int[] arr7 = new int[6];            
            Program.ReadFromConsoleAndCompare(arr5, arr6);

            // 6.
            int[,] arr8 = new int[6, 6];
            Program.AddArr(arr8);
            Console.WriteLine(Program.SumDiagonals(arr8));
        }
        public static void AddArr4(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
        public static bool ReadFromConsoleAndCompare(int[] arr_1, int[] arr_2)
        {
            Console.WriteLine("Enter first Array's data");
            for (int i = 0; i < arr_1.Length; i++)
            {
                var s = Console.ReadLine();
                if(string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
                {
                    i--;
                    continue;
                }
                int.TryParse(s, out arr_1[i]);
            }
            Console.WriteLine("Enter second Array's data");            
            for (int i = 0; i < arr_2.Length; i++)
            {
                var s = Console.ReadLine();
                if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
                {
                    i--;
                    continue;
                }
                int.TryParse(s, out arr_2[i]);
            }
            if (!arr_1.Length.Equals(arr_2.Length))
            {
                Console.WriteLine("Arrays are not equal");
                return false;
            }
            for(int i = 0; i < arr_1.Length; i++)
            {
                if(arr_1[i] != arr_2[i])
                {
                    Console.WriteLine("Arrays are not equal");
                    return false;
                }                   
            }
            Console.WriteLine("Arrays are equal");
            return true;  
        }
        public static int SumDiagonals(int[,] arr)
        {
            int sum = 0;
            for (int i = 0, g = arr.GetLength(1) - 1; i < arr.GetLength(0); i++, g--)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(i == j)
                        sum += arr[i, j];
                    //if (i == j && i == g)
                    //    continue;
                    if (j == g)
                        sum += arr[i, j];
                }
            }
            return sum;
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
                    arr[i, j] = rand.Next(0, 10);
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
