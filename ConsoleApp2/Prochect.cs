using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Operations
    {
        public static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static void Swap<T>(ref T x, ref T y) where T : struct
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static double SumOfFirstHalfDigits(int number)
        {
            int sum = 0;
            string numStr = number.ToString();

            foreach (var digit in numStr.Take(numStr.Length / 2))
            {
                sum += int.Parse(digit.ToString());
            }

            return sum;
        }
        
    }



