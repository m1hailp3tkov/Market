namespace Market.Models.Cards
{
    public sealed class BronzeCard : DiscountCard
    {
        private decimal discountRate;

        public BronzeCard(string owner, decimal turnover) : base(owner, turnover) 
        {
            this.discountRate = this.Turnover >= 300 ? 0.025m : this.Turnover >= 100 ? 0.01m : 0;
        }

        public override decimal DiscountRate => this.discountRate;
    }
}
