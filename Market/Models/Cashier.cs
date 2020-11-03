using Market.Contracts;
using System;

namespace Market.Models
{
    public class Cashier
    {
        public PurchaseInformaton ProcessPurchase(decimal purchaseValue, IDiscountCard card)
        {
            if (purchaseValue < 0)
            {
                throw new ArgumentException(nameof(purchaseValue), $"{nameof(purchaseValue)} cannot be less than 0");
            }

            return new PurchaseInformaton
            {
                DiscountRate = card.DiscountRate,
                PurchaseValue = purchaseValue
            };
        }
    }
}
