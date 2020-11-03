using System;

namespace Market.Models.Cards
{
    public class GoldCard : DiscountCard
    {
        private decimal discountRate;

        public GoldCard(string owner, decimal turnover) : base(owner, turnover)
        {
            this.discountRate = Math.Min(this.Turnover / 100 * 0.01m + 0.02m, 0.1m);
        }

        public override decimal DiscountRate => this.discountRate;
    }
}
