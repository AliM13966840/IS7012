namespace RecruitCatAdekunle.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; } // Nullable
        public string Location { get; set; }

        // Additional properties
        public int NumberOfEmployees { get; set; }
        public string WebsiteUrl { get; set; } 
    }


}
