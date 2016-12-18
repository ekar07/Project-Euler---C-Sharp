using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAXNUMBER = 1000;
            int SUM = 0;
            for (int i = 1; i < MAXNUMBER; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    SUM += i;
                }
            }
            Console.WriteLine(SUM);
            Console.ReadLine();
        }
    }
}
