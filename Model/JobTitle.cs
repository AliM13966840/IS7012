namespace RecruitCatAdekunle.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }

        // Additional properties
        public string JobDescription { get; set; } 
    }


}

