//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CodeWars
//{
//    internal class CodeWarsPractice
//    {
//        static void Main(string[] args)
//        {

//            SquareDigits(765);
//        }
//        // 29.06.26
//        public static string CalculateAge(int birth, int yearTo)
//        {
//            if (birth < yearTo)
//            {
//                if (yearTo - birth == 1) return "You are 1 year old.";
//                else return $"You are {yearTo - birth} years old.";
//            }
//            else if (birth == yearTo) return "You were born this very year!";
//            else if (birth > yearTo)
//            {
//                if (birth - yearTo == 1) return "You will be born in 1 year.";
//                else return $"You will be born in {birth - yearTo} years.";
//            }
//            else return null;
//        }
//        //30.06.26
//        public static double SumArray(double[] array)
//        {
//            return array.Sum();
//        }
//        //01.07.26
//        public static int GetSum(int a, int b)
//        {
//            int result;
//            if (a == b) return a;
//            else if (a < b)
//            {
//                result = a;
//                for (int i = a + 1; i <= b; i++)
//                {
//                    result += i;
//                }
//                return result;
//            }
//            else if (a > b)
//            {
//                result = b;
//                for (int i = b + 1; i <= a; i++)
//                {
//                    result += i;
//                }
//                return result;
//            }
//            else return 0;
//        }
//        // 03.07.26
//        public static int[] ReverseSeq(int n)
//        {
//            int[] array = new int[n];
//            int counter = n;
//            for (int i = 0; i < counter; i++)
//            {
//                array[i] = n;
//                n--;
//            }
//            return array;
//        }
//        // 04.07.26 7kuy
//        public static int SquareDigits(int n)
//        {
//            string? result = null;
//            string str = Convert.ToString(n);
//            foreach(char c in str)
//            {
//                string a = Convert.ToString(c); int b = Convert.ToInt32(a); result += Convert.ToString(b * b);
//            }
//            return Convert.ToInt32(result);
//        }
//    }
//}
