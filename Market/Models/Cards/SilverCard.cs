namespace Market.Models.Cards
{
    public sealed class SilverCard : DiscountCard
    {
        private decimal discountRate;

        public SilverCard(string owner, decimal turnover) : base(owner, turnover) 
        {
            this.discountRate = this.Turnover >= 300 ? 0.035m : 0.025m;
        }

        public override decimal DiscountRate => this.discountRate;
    }
}
