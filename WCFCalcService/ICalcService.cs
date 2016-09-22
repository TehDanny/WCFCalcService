using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalcService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalcService" in both code and config file together.
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Substract(int a, int b);

        [OperationContract]
        int Multiply(int a, int b);

        [OperationContract]
        IntDivisionResult Divide(int a, int b);
    }
}
