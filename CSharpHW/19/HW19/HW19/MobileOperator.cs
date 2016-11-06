using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW19
{
    public class MobileOperator
    {
        private List<int> _callToAccounts = new List<int>();
        private List<int> _callFromAccounts = new List<int>();
        private List<int> _smsToAccounts = new List<int>();
        private List<int> _smsFromAccounts = new List<int>(); 

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
                _smsFromAccounts.Add(numberFrom);
                _smsToAccounts.Add(numberTo);
            }
        }

        private void RouteCall(int numberTo, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.TryGetValue(numberTo, out acc))
            {
                acc.ReceiveCall(numberFrom);
                _callFromAccounts.Add(numberFrom);
                _callToAccounts.Add(numberTo);
            }
        }

        public List<int> Get5MostCallingNumbers()
        {
            return _callToAccounts
                    .GroupBy(num => num)
                    .OrderByDescending(num => num.Count())
                    .Take(5)
                    .Select(num => num.Key).ToList();
        }

        public void Get5MostActiveNumbers()
        {
            var groupsCall = _callFromAccounts.GroupBy(call => call);

            var groupsSMS = _smsFromAccounts.GroupBy(sms => sms);


            var leftoutrtjoin = (from sms in groupsSMS

                join call in groupsCall on sms.Key equals call.Key into SC

                from newSC in SC.DefaultIfEmpty()

                select new
                {
                    account = sms.Key,
                    activity = newSC?.Count() + (double) sms.Count()/2 ?? (double) sms.Count()/2
                }).ToList();

            var rightouterjoin = (from call in groupsCall

                join sms in groupsSMS on call.Key equals sms.Key into CS

                from newCS in CS.DefaultIfEmpty()

                select new
                {
                    account = call.Key,
                    activity = newCS == null ? call.Count() : (double) newCS.Count()/2 + call.Count()
                }).ToList();


            var fullouterjoin = leftoutrtjoin.Union(rightouterjoin);

            var result = (from account in fullouterjoin
                orderby account.activity descending
                select account.account).Take(5);


            Console.WriteLine("5 Most Active Numbers: ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
