using System;
using System.Collections.Generic;
using System.Text;

namespace MybankerH2
{
    class Maestro : Card, IExpireDate
    {
        public DateTime ExpiryDate { get; set;}
        public Maestro(string cardName) : base(cardName)
        {
            //This is Card Prefix array, so when the CardNumber is generates it looks here for the prefix array
            Prefix = new string[]
           {
                "5018",
                "5020",
                "5038",
                "5893",
                "6304",
                "6759",
                "6761",
                "6762",
                "6763"
           };
            //FullLength property from Card, is set to 19 because Maestro needs 19 digits
            FullLength = 19;
            ExpiryDate = DateTime.Now.AddYears(5).AddMonths(8);
        }
        public override string ToString()
        {
            return base.ToString() + ExpiryDate;
        }
    }
}
