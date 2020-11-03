using System.Text;

namespace Market.Models
{
    public class PurchaseInformaton
    {
        public decimal PurchaseValue { get; set; }

        public decimal DiscountRate { get; set; }

        public override string ToString()
        {
            var str = new StringBuilder();

            str.AppendLine($"Purchase value:\t${this.PurchaseValue:F2}");
            str.AppendLine($"Discount rate:\t{this.DiscountRate * 100:F1}%");
            str.AppendLine($"Discount:\t${this.DiscountRate * this.PurchaseValue:F2}");
            str.AppendLine($"Total:\t\t${this.PurchaseValue * (1 - this.DiscountRate):F2}");
            str.AppendLine("----------------------------------");

            return str.ToString();
        }
    }
}
