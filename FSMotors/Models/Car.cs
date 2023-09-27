using System.ComponentModel.DataAnnotations;

namespace FSMotors.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string FuelMilage { get; set; }
        public string Features { get; set; }
        public string Description { get; set; }
        public string EngineNo { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }  
        public int MaintananceCost { get; set; }
        public int ShowroomCost { get; set; }
        public int SalesTax  { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int ShowroomId { get; set; }
        public int InvestorId { get;set; }
        
    }
}
