using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("maximum number:");
            int MaxNumber = Check.MaximumInteger(11, 22, 33);
            Console.WriteLine(MaxNumber);

            Console.ReadLine();

        }
    }
}
