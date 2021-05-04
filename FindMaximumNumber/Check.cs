using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
   public class Check
    {
        public static int MaximumInteger(int firstNumber, int secondtNumber, int thirdtNumber)
        {

            if (firstNumber.CompareTo(secondtNumber) > 0 && firstNumber.CompareTo(thirdtNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondtNumber.CompareTo(firstNumber) > 0 && secondtNumber.CompareTo(thirdtNumber) > 0)
            {
                return secondtNumber;
            }
            else if (thirdtNumber.CompareTo(secondtNumber) > 0 && thirdtNumber.CompareTo(firstNumber) > 0)
            {
                return thirdtNumber;
            }
            throw new Exception("firstNumber,secondNumber,ThirdNumber are same");

        }

        

        public static float MaximumFloat(float firstNumber, float secondtNumber, float thirdtNumber)
        {

            if (firstNumber.CompareTo(secondtNumber) > 0 && firstNumber.CompareTo(thirdtNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondtNumber.CompareTo(firstNumber) > 0 && secondtNumber.CompareTo(thirdtNumber) > 0)
            {
                return secondtNumber;
            }
            else if (thirdtNumber.CompareTo(secondtNumber) > 0 && thirdtNumber.CompareTo(firstNumber) > 0)
            {
                return thirdtNumber;
            }
            throw new Exception("firstNumber,secondNumber,ThirdNumber are same");

        }

        public static string MaximumString(string first, string second, string third)
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("first,second,Third are same");

        }
    }

}

