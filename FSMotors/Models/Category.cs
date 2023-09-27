using System;

namespace FSMotors.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string MakeCompany { get; set; }
        public DateTime MakeYear { get; set; }
        public string NoOfCylinders { get; set; }
        public string HoresPower { get; set; }
        public string TransmissionMode { get; set; }
        public string TankCapacity { get; set; }
        public int Doors { get; set; }
        public int PassangerCapacity { get; set; }
        public string FuelMilage { get; set; }
        public string FuelType { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public string InteriorImage { get; set; }
        public string EngineImage { get; set; }
        public string BodyImage { get; set; }
    }
}
