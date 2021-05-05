using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
   public class Check
    {
        public static int MaximumInteger(int FirstValue, int SecondValue, int ThirdValue)
        {

            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
            {
                return FirstValue;
            }
            else if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
            {
                return SecondValue;
            }
            else if (ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(FirstValue) > 0)
            {
                return ThirdValue;
            }
            throw new Exception("FirstValue,SecondValue,ThirdValue are same");

        }

        

        public static float MaximumFloat(float FirstValue, float SecondValue, float ThirdValue)
        {

            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
            {
                return FirstValue;
            }
            else if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
            {
                return SecondValue;
            }
            else if (ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(FirstValue) > 0)
            {
                return ThirdValue;
            }
            throw new Exception("FirstValue,SecondValue,ThirdValue are same");

        }

        public static string MaximumString(string FirstValue, string SecondValue, string ThirdValue)
        {

            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
            {
                return FirstValue;
            }
            else if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
            {
                return SecondValue;
            }
            else if (ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(FirstValue) > 0)
            {
                return ThirdValue;
            }
            throw new Exception("FirstValue,SecondValue,ThirdValue are same");

        }
    }

}

