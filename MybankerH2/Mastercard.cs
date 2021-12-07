using System;
using System.Collections.Generic;
using System.Text;

namespace MybankerH2
{
    class Mastercard : Card, IExpireDate, IMontlyLimit
    {
        public DateTime ExpiryDate { get; set; }
        public int Limit { get; set; }
        public int DailyLimit { get; private set; } = 5000;
        public int CreditLimit { get; private set; } = 40000;

        public Mastercard(string cardName) : base(cardName)
        {
            //This is Card Prefix array, so when the CardNumber is generates it looks here for the prefix array
            Prefix = new string[]
            {
                "51",
                "52",
                "53",
                "54",
                "55"
            };
            Limit = 30000;
            ExpiryDate = DateTime.Now.AddYears(5);
        }
        public override string ToString()
        {
            return base.ToString() + ExpiryDate;
        }
    }
}
