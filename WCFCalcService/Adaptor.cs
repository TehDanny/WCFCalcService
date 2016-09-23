using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalculatorDomain;


namespace WCFCalcService
{
    internal class Adaptor
    {
        internal static int Add(int a, int b)
        {
            return SimpleCalculations.Add(a, b);
        }

        internal static IntDivisionResult Divide(int a, int b)
        {
            IntDivisionResult result = new IntDivisionResult();
            result.Quotient = SimpleCalculations.Divide(a, b);
            result.Remainder = SimpleCalculations.Modulus(a, b);
            return result;
        }

        internal static int Multiply(int a, int b)
        {
            return SimpleCalculations.Multiply(a, b);
        }

        internal static int Substract(int a, int b)
        {
            return SimpleCalculations.Substract(a, b);
        }
    }
}