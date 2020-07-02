namespace MarketStore.Models
{
    internal sealed class SilverCard : Card
    {
        public SilverCard(decimal turnover, decimal purchaseValue) : base(turnover, purchaseValue)
        {
            if (turnover > 300) discountRate = 0.035m;
            else discountRate = 0.02m;
        }
    }
}
