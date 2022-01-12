using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloword1
{
    internal class ReplaceWord
    {
        public static void ReadingInputFromUser()
        {
            Console.WriteLine("Please enter your user name");
            string name=Console.ReadLine();
            if(name.Length>=3)
            {
                ReplaceStringWithTemplate(name);
            }
            else
            {
                Console.WriteLine("Please provide your name at least 3 characters");
            }
        }
        public static void ReplaceStringWithTemplate(string name)
        {
            string template = "Hello  <<UserName>>, How are you?";
            if (template.Contains("<<UserName>>"))
            {
                string result = template.Replace("<<UserName>>", name);
                Console.WriteLine("After Replace" +result);
            }
            else
            {
                Console.WriteLine("UserName not exits");
            }
        }
    }
}
