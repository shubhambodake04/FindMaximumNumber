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

            /*Console.WriteLine("maximum number:");
            int MaxNumber = Check.MaximumInteger(11, 22, 33);
            Console.WriteLine(MaxNumber);

            float MaxNumber1 = Check.MaximumFloat(4.8f, 2.7f, 3.9f);
            Console.WriteLine(MaxNumber1);

            string MaxNumber2 = Check.MaximumString("shubham","amol","ravi");
            Console.WriteLine(MaxNumber2);*/

            Check<int> MaximumInteger = new Check<int>(11, 22, 33);
            Check<float> MaximumFloat = new Check<float>(4.3f, 2.3f, 3.3f);
            Check<string> MaximumString = new Check<string>("shubham", "amol", "ravi");

            Console.WriteLine("MaximumInteger:" + MaximumInteger.MaximumMethod());
            Console.WriteLine("MaximumFloat:" + MaximumFloat.MaximumMethod());
            Console.WriteLine("MaximumString:" + MaximumString.MaximumMethod());

            Console.ReadLine();

        }
    }
}
