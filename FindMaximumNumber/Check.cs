using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
   public class Check<T> where T:IComparable
   { 

    public T FirstValue, SecondValue, ThirdValue;
    public Check(T FirstValue, T SecondValue, T ThirdValue)
        {
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = ThirdValue;
        }
    public static T Maximum(T FirstValue, T SecondValue, T ThirdValue)
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
    public T MaximumMethod()
    {
        T Maximum = Check<T>.Maximum(this.FirstValue, this.SecondValue, this.ThirdValue);

        return Maximum;

    }
    
       /* public static int MaximumInteger(int FirstValue, int SecondValue, int ThirdValue)
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

        }*/
    }

}

