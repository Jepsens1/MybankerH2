using System;
using System.Collections.Generic;
using System.Text;

namespace MybankerH2
{
    class VisaDankort : Card, IExpireDate, IMontlyLimit
    {
        public DateTime ExpiryDate { get; set; }
        public int Limit { get; set; }
        public int SpendingLimit { get; private set; } = 20000;

        public VisaDankort(string cardName) : base(cardName)
        {
            //This is Card Prefix array, so when the CardNumber is generates it looks here for the prefix array
            Prefix = new string[]
            {
                "4"
            };
            Limit = 25000;
            ExpiryDate = DateTime.Now.AddYears(5);
        }
        public override string ToString()
        {
           return base.ToString() + ExpiryDate;
        }
    }
}
