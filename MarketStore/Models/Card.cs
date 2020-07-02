using System;
using System.Text;

namespace MarketStore.Models
{
    internal abstract class Card
    {
        private decimal turnover;
        private decimal purchaseValue;
        private protected decimal discountRate;

        public Card(decimal turnover, decimal purchaseValue)
        {
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;
        }

        private decimal GetDiscount()
        {
            return purchaseValue * discountRate;
        }

        private decimal CalculatePurchaseTotal()
        {
            var discount = GetDiscount();
            var result = this.purchaseValue - discount;
            return result;
        }

        public string GetTransactionInformation()
        {
            var result = new StringBuilder();
            result.AppendLine($"Purchase value: ${purchaseValue:f2}");
            result.AppendLine(String.Format($"Discount rate: {discountRate:P1}"));
            result.AppendLine($"Discount: ${GetDiscount():f2}");
            result.AppendLine($"Total: ${CalculatePurchaseTotal():f2}");
            return result.ToString();
        }
    }
}
