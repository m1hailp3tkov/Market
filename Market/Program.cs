using Market.Models;
using Market.Models.Cards;
using System;
using System.Linq;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashier = new Cashier();

            var bronzeCard = new BronzeCard("Bronze", 0);
            var silverCard = new SilverCard("Silver", 600);
            var goldCard = new GoldCard("Gold", 1500);

            var receipts = new PurchaseInformaton[]
            {
                cashier.ProcessPurchase(150, bronzeCard),
                cashier.ProcessPurchase(850, silverCard),
                cashier.ProcessPurchase(1300, goldCard)
            };

            foreach (var receipt in receipts) Console.WriteLine(receipt);
        }
    }
}
