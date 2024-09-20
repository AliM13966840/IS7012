namespace RecruitCatAdekunle.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; } // Nullable

        // Additional properties
        public DateTime DateOfBirth { get; set; } 
        public bool IsCurrentlyEmployed { get; set; } 
    }

}
