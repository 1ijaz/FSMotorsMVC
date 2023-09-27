using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FSMotors.Models
{
    public class Investor : User
    {
        [Key]
        public int Id { get; set; }
        public decimal InvestmentAmount { get; set; }
        public DateTime InvestmentDate { get; set; }
        public string InvestmentStatus { get; set; }
        public decimal TotalProfit { get; set; }
        public decimal UnAllocatedAmout { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

   
    }
}
