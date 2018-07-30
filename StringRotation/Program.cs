using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the word you want to shift around: ");
            string[] shiftedString = shiftString(Console.ReadLine());

            foreach (string word in shiftedString)
            {
                Console.Write(word + " ");
            }

            Console.ReadKey();
        }

        public static string[] shiftString(string myString)
        {
            Stack<string> shiftedStack = new Stack<string>();

            char[] afterShiftString = myString.ToCharArray();

            for (int i = 0; i <= myString.Length - 1; i++)
            {
                shiftedStack.Push(new string(afterShiftString));

                char lastChar = afterShiftString.Last();
                for (int c = myString.Length - 1; c > 0; c--)
                {
                    afterShiftString[c] = afterShiftString[c - 1];
                }
                afterShiftString[0] = lastChar;
            }

            return shiftedStack.ToArray();
        }
    }
}
