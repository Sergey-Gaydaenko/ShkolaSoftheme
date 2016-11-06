using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class MobileOperator
    {
        private Dictionary<int, MobileAccount> _accounts = new Dictionary<int, MobileAccount>();
        public MobileAccount CreateAccount(int number)
        {
            var acc = new MobileAccount(number, this);
            _accounts.Add(number, acc);
            acc.OnMessagePost += RouteMessage;
            acc.OnCall += RouteCall;
            return acc;
        }

        private void RouteMessage(int numberTo, string message, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.TryGetValue(numberTo, out acc))
            {
                acc.ReceiveMessage(numberFrom, message);
            }
        }

        private void RouteCall(int numberTo, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.TryGetValue(numberTo, out acc))
            {
                acc.ReceiveCall(numberFrom);
            }
        }


    }
}
