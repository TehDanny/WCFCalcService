using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFCalcClient.CalcService;

namespace WCFCalcClient
{
    class Controller
    {
        CalcServiceClient client;

        public Controller()
        {
            client = new CalcServiceClient();
        }

        internal int Add(string text1, string text2)
        {
            return client.Add(Convert.ToInt32(text1), Convert.ToInt32(text2));
        }

        internal int Substract(string text1, string text2)
        {
            return client.Substract(Convert.ToInt32(text1), Convert.ToInt32(text2));
        }

        internal int Divide(string text1, string text2)
        {
            return client.Divide(Convert.ToInt32(text1), Convert.ToInt32(text2)).Quotient;
        }

        internal int Modulus(string text1, string text2)
        {
            return client.Divide(Convert.ToInt32(text1), Convert.ToInt32(text2)).Remainder;
        }

        internal int Multiply(string text1, string text2)
        {
            return client.Multiply(Convert.ToInt32(text1), Convert.ToInt32(text2));
        }
    }
}
