﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalcService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalcService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalcService.svc or CalcService.svc.cs at the Solution Explorer and start debugging.
    public class CalcService : ICalcService
    {
        public int Add(int a, int b)
        {
            return Adaptor.Add(a, b);
        }

        public IntDivisionResult Divide(int a, int b)
        {
            return Adaptor.Divide(a, b);
        }

        public int Multiply(int a, int b)
        {
            return Adaptor.Multiply(a, b);
        }

        public int Substract(int a, int b)
        {
            return Adaptor.Substract(a, b);
        }
    }
}
