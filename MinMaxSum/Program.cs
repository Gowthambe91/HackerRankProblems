using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(array);
            Console.ReadLine();
        }

        static void miniMaxSum(int[] arr)
        {
            int minSum = 0; int maxSum = 0;
            Int64 Sum = arr.Sum();
            int minVal = arr.Min();
            int maxVal = arr.Max();
            List<int> lst = arr.ToList<int>();
            lst.Sort();
            
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i != arr.Length - 1)
            //    {
            //        minSum += arr[i];
            //    }

            //    if (i != 0)
            //    {
            //        maxSum += arr[i];
            //    }
            //}

            Console.WriteLine("{0} {1} Sum = {2}, minVal = {3}, maxVal = {4}, lstSum = {5}", Sum - maxVal, Sum - minVal, Sum, minVal
                ,maxVal, lst.Sum());
        }
    }
}
