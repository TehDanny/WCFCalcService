using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFCalcService
{
    [DataContract]
    public class IntDivisionResult
    {
        [DataMember]
        public int Kvotioent;
        [DataMember]
        public int Rest;
    }
}