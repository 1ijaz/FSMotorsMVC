using System;
using System.ComponentModel.DataAnnotations;

namespace FSMotors.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int InvestorId { get; set; }
        public Investor Investor { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string BuyerName { get; set; }
        public string BuyerContact { get; set; }
        public string BuyerAddress { get; set; }
        public int? TaxRate { get; set; }
        public int? TotalAmount { get; set; }
        public decimal Profit { get; set; }
        public Transaction(decimal carPrice, decimal workshopCost, decimal showroomCost, decimal taxRate)
        {
            CalculateProfit(carPrice, workshopCost, showroomCost, taxRate);
        }
        public void CalculateProfit(decimal carPrice, decimal workshopCost, decimal showroomCost, decimal taxRate)
        {
            decimal profit = carPrice + workshopCost + showroomCost + (carPrice * taxRate);
            Profit = profit;
        }
    }
}
