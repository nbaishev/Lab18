using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            bool fl = true;
            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '(':
                        brackets.Push(')');
                        break;
                    case '[':
                        brackets.Push(']');
                        break;
                    case '{':
                        brackets.Push('}');
                        break;
                }
                if ((str[i] == ')') || (str[i] == ']') || (str[i] == '}'))
                {
                    if ((brackets.Count == 0) || (str[i] != brackets.Pop()))
                    {
                        fl = false;
                    }
                }
            }

            if ((brackets.Count == 0) && (fl))
            {
                Console.WriteLine("Скобки расставлены верно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены неверно");
            }
            Console.ReadKey();
        }
    }
}
