using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_3._1
{
    internal class Program
    {
        static bool Contain( string s)
        {
            string s1 = "SQ";
            string s2 = "QS";
            bool b = s.Contains(s1);
            if(b == true)
                return b;
            else
                b = s.Contains(s2);

            return b;
        }
        static int CountWords(string test)
        {
            int count = 0;
            bool wasInWord = false;
            bool inWord = false;

            for (int i = 0; i < test.Length; i++)
            {
                if (inWord)
                {
                    wasInWord = true;
                }

                if (Char.IsWhiteSpace(test[i]))
                {
                    if (wasInWord)
                    {
                        count++;
                        wasInWord = false;
                    }
                    inWord = false;
                }
                else
                {
                    inWord = true;
                }
            }

           
            if (wasInWord)
                count++;
            

            return count;
        }

        static void Main(string[] args)
        {
            string s;
            Console.Write("Enter string: ");
            s = Console.ReadLine();
            bool b = Contain(s);

            Console.Write("1) Whether there is a pair of adjacent letters SQ or QS among the characters:\n");
            if (b)
                Console.Write("Yes\n");
            else
                Console.Write("No\n");

            Console.WriteLine("2) Кeplace SQ or QS with *** :");
            
            string s2 =s.Replace("SQ", "***");
            s2 = s2.Replace("QS", "***");
            Console.WriteLine(s2);

            Console.Write($"3) Number of words = {CountWords(s)}");
         


            Console.ReadKey();
        }
    }
}
