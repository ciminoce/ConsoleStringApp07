using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringApp07
{
    class Program
    {
        static void Main(string[] args)
        {
            var nroCaracteres = 10;
            StringBuilder password = new StringBuilder();
            Random r = new Random();
            for (int i = 0; i < nroCaracteres; i++)
            {
                char c =(char) r.Next(33, 126);
                password.Append(c);
            }

            Console.WriteLine(password.ToString());
            Console.ReadLine();
        }
    }
}
