using System;
using System.Collections.Generic;
using System.Text;

namespace MybankerH2
{
    class Card
    {
        public string CardName { get; protected set; }
        public string CardNumber { get; protected set; }
        public string[] Prefix { get; protected set; }
        public string CurrentPrefix { get; protected set; }
        public string AccountNumber { get; protected set; }
        public int FullLength { get; protected set; } = 16;
        public Card(string cardName)
        {
            CardName = cardName;
        }
        //Override ToString to write out information about the card
        public override string ToString()
        {
            RetriveInfo();
            return $"CardName: {CardName}\nCardNumber: {CardNumber}\nPrefix: {CurrentPrefix}\nAccountNumber: {AccountNumber}";
        }
        //Generates the card number, first call the prefixSelect so, our card start with prefix
        public string GenerateCardNumber()
        {
            PreFixSelect();
            Random r = new Random();
            CardNumber += CurrentPrefix;
            for (int i = 0; i < FullLength - CurrentPrefix.Length; i++)
            {
                CardNumber += $"{r.Next(0, 9)}";
            }
            return CardNumber;
        }
        //Picks a random Prefix from the prefix array, So when creating a VisaElectron, it picks a random prefix from the visaelectron prefix array
        public void PreFixSelect()
        {
            Random r = new Random();
            CurrentPrefix = Prefix[r.Next(0, Prefix.Length)];
        }
        //Generates our AccountNumber, and prefix is already set
        public string GenerateAccountNumber()
        {
            Random r = new Random();
            AccountNumber += "3520";
            for (int i = 0; i < 10; i++)
            {
                AccountNumber += $"{r.Next(0, 9)}";
            }
            return AccountNumber;
        }
        //Method that calls GenerateAccount and GenerateNumber
        public void RetriveInfo()
        {
            GenerateCardNumber();
            GenerateAccountNumber();
        }
    }
}
