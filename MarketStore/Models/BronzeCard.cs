namespace MarketStore.Models
{
    internal sealed class BronzeCard : Card
    {
        public BronzeCard(decimal turnover, decimal purchaseValue) : base(turnover, purchaseValue)
        {
            if (turnover < 100) this.discountRate = 0m;
            else if (turnover >= 100 && turnover <= 300) this.discountRate = 0.01m;
            else if (turnover > 300) this.discountRate = 0.025m;
        }
    }
}
