using System;
using System.Collections.Generic;
using System.Text;

namespace MybankerH2
{
    class Haevekort : Card
    {
        public Haevekort(string cardName) : base(cardName)
        {
            //This is Card Prefix array, so when the CardNumber is generates it looks here for the prefix array
            Prefix = new string[]
           {
               "2400"
           };
        }
    }
}
