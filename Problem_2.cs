using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Program
    {

		static string CheckDuplicates(int a,int b , int c,string testString)
        {
            if (b <=c)
            {

                if (a == 0)
                {
                    if (testString[a] != testString[b])
                    {
                        Console.WriteLine(testString[a]);
                    }
                }else if (a==c-1 && testString[1] != testString[a-1])
                {
                    Console.WriteLine(testString[a]);
                }
                else
                {
                    if (testString[a] != testString[b] && testString[a - 1] != testString[a])
                    {
                        Console.WriteLine(testString[a]);
                    }
                }

                return CheckDuplicates(b, b + 1, c, testString);

            }
            else
            {
                return "";
            }

            
        }

		static void Main(string[] args)
        {

			string testStringing = "Hello Spartaan";

            CheckDuplicates(0, 1, testStringing.Length, testStringing);
            Console.ReadKey();
		}

		

    }
}
