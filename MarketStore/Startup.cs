using MarketStore.Models;
using System;

namespace MarketStore
{
    class Startup
    {
        static void Main()
        {
            var bronzeCard = new BronzeCard(0, 150);
            Console.WriteLine(bronzeCard.GetTransactionInformation());

            var silverCard = new SilverCard(600, 850);
            Console.WriteLine(silverCard.GetTransactionInformation());

            var goldCard = new GoldCard(1500, 1300);
            Console.WriteLine(goldCard.GetTransactionInformation());
        }
    }
}
