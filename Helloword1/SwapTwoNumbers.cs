using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloword1
{
    internal class SwapTwoNumbers
    {
        
            public int first, second;
            public static int x = 0, y = 0;

            //static method for reading input from user
            public void ReadingInputFromUser()
            {
                Console.WriteLine("Please enter first number");
                first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter second number");
                second = Convert.ToInt32(Console.ReadLine());
                SwapNumbers();
            }

            public void SwapNumbers()
            {
                int temp = 0;
                Console.WriteLine("Before swaping: first={0} second={1}", first, second);
                temp = first;
                first = second;
                second = temp;
                Console.WriteLine("After swaping: first={0} second={1}", first, second);
            }
        }
    }
