using System;
using System.Collections.Generic;
using System.Text;

namespace MybankerH2
{
    class VisaElectron : Card, IExpireDate, IMontlyLimit
    {
        public DateTime ExpiryDate { get; set; }
        public int Limit { get; set; }

        public VisaElectron(string cardName) : base(cardName)
        {
            //This is Card Prefix array, so when the CardNumber is generates it looks here for the prefix array
            Prefix = new string[]
            {
                "4026",
                "417500",
                "4508",
                "4844",
                "4913",
                "4917"
            };
            //MontlyLimit
            Limit = 10000;
            ExpiryDate = DateTime.Now.AddYears(5);
        }
        public override string ToString()
        {
            return base.ToString() + ExpiryDate;
        }
    }
}
