using System;

namespace MarketStore.Models
{
    internal sealed class GoldCard : Card
    {
        public GoldCard(decimal turnover, decimal purchaseValue) : base(turnover, purchaseValue)
        {
            var rate = 0.02m;

            for (int i = 0; i < Math.Floor(turnover / 100); i++)
            {
                rate += 0.01m;
                if (rate == 0.1m) break;
            }

            this.discountRate = rate;
        }
    }
}
