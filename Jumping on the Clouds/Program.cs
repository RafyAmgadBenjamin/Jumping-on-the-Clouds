using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumpsCount = 0;
            for (int i = 0; i < c.Length-1; i++)
            {
                if(i<c.Length-2&c[i + 1] == 0 && c[i + 2] == 0&& c[i] == 0)
                {
                    jumpsCount++;
                    i++;
                }
                else if (c[i+1] == 0)
                {
                    jumpsCount++;
                }
               
            }
            return jumpsCount;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);

            //textWriter.Flush();
           // textWriter.Close();
        }
    }
}
