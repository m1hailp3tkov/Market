using Market.Contracts;
using System;

namespace Market.Models.Cards
{
    public abstract class DiscountCard : IDiscountCard
    {
        public DiscountCard(string owner, decimal turnover)
        {
            //parameter validations
            if (string.IsNullOrEmpty(owner)) throw new ArgumentException(nameof(owner), $"{nameof(owner)} cannot be null or empty.");
            if (turnover < 0) throw new ArgumentOutOfRangeException(nameof(turnover), $"{nameof(turnover)} cannot be smaller than 0");

            this.Owner = owner;
            this.Turnover = turnover;
        }

        public string Owner { get; }

        public abstract decimal DiscountRate { get; }

        protected decimal Turnover { get; private set; }
    }
}
