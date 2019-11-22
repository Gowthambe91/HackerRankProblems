using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleandOrangeCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Start and End Position of Sam's House with spaces:");
            string[] st = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(st[0]); //start point
            int t = Convert.ToInt32(st[1]); // end point

            Console.WriteLine("\n Enter the Position of Apple and Orange tree with spaces:");
            string[] ab = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(ab[0]); //apple tree's position
            int b = Convert.ToInt32(ab[1]); // orange tree's position

            Console.WriteLine("\n Enter the number of apples and orange with space seperation:");
            string[] mn = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]); //no. of apples
            int n = Convert.ToInt32(mn[1]); // no. of oranges
                        
            Console.WriteLine("\n Enter the distances of {0} apples fell from the tree:", m);
            int[] distanceApples = Array.ConvertAll(Console.ReadLine().Split(' '), tempApples => Convert.ToInt32(tempApples));

            Console.WriteLine("\n Enter the distances of {0} oranges fell from the tree:", m);
            int[] distanceOranges = Array.ConvertAll(Console.ReadLine().Split(' '), tempOranges => Convert.ToInt32(tempOranges));

            CountApplesOranges(s, t, a, b, distanceApples, distanceOranges);

            Console.ReadLine();
        }

        static void CountApplesOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //int noOfApplesAtSamHouse = apples.Select(apple => (apple + a) >= s && (apple + a) <= t ? apple : 0).Where(apple => apple != 0).Count();
            //int noOfOrangesAtSamHouse = oranges.Select(orange => (orange + b) >= s && (orange + b) <= t ? orange : 0).Where(orange => orange != 0).Count();

            int noOfApplesAtSamHouse = apples.Where(apple => s <= (apple + a) && (apple + a) <= t).Count();//Easier than the above!
            int noOfOrangesAtSamHouse = oranges.Where(orange => s <= (orange + b) && (orange + b) <= t).Count();

            Console.WriteLine("Number of Apples and Oranges fell in Sam's house respectively are : {0} \t {1} ", noOfApplesAtSamHouse, noOfOrangesAtSamHouse);
        }
    }
}

