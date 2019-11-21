using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sTimein12Hr = Console.ReadLine();
            string sTimein12Hr = "12:05:45PM";
            string resultin24Hr = timeConversion(sTimein12Hr);

            Console.WriteLine("resultin12Hr : {0} \t  resultin24Hr : {1} ",sTimein12Hr, resultin24Hr);

            Console.ReadLine();
        }

        static string timeConversion(string sTimein12HrFormat)
        {
            string[] strTimeSplitted = sTimein12HrFormat.Split(':');
            string result = "";

            double hrsDouble = Convert.ToDouble(strTimeSplitted[0]);
            string hrsString = strTimeSplitted[0];
            string mins = strTimeSplitted[1];

            //Regex re = new Regex(@"(\d+)([a-zA-Z]+)");
            //Match matchSeconds = re.Match(strTimeSplitted[2]); Fine, but Regular Expression namespace not added in the HackerRank Problem

            //int secs = Convert.ToInt32(matchSeconds.Groups[1].Value);
            //string AMOrPM = matchSeconds.Groups[2].Value;

            string secs = strTimeSplitted[2].Substring(0,2);
            string AMOrPM = strTimeSplitted[2].Substring(2, 2);

            if (AMOrPM.Equals("AM") && hrsDouble == 12)
            {
                hrsString = "00";
            }            
            else if (AMOrPM.Equals("PM") && hrsDouble != 12)
            {
                hrsDouble = 12 + hrsDouble;
                hrsString = hrsDouble.ToString();
            }
            else
            {
               // Do nothing
            }
            

            result = hrsString + ":" + mins + ":" + secs;

            return result;

        }
    }
}
