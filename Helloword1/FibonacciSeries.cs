using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloword1
{
    internal class FibonocciSeries
    {
        public int firstNum = 0, secondNum = 1, result = 0;
        public void FindFibonocciSeries()
        {
            Console.WriteLine("Please Enter number to generate series ");
            int num=Convert.ToInt32(Console.ReadLine());
            result = firstNum + secondNum;

            Console.Write("Series are" + firstNum + " " + secondNum);
            for(int i=2; i<num;i++)
            {
                firstNum = secondNum;
                secondNum = result;
                Console.Write(" " + result);
                result=firstNum + secondNum;
            }
        }
    }
}
