﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double num1, double num2)
        {
            double result = 0;
            result = num1 + num2;

            return result;
        }

        public static double Subtract(double num1, double num2)
        {
            double result = 0;
            result = num1 - num2;

            return result;
        }

        public static double Multiply(double num1, double num2)
        {
            throw new NotImplementedException();
        }

        public static double Divide(double num1, double num2)
        {
            throw new NotImplementedException();
        }
    }
}
