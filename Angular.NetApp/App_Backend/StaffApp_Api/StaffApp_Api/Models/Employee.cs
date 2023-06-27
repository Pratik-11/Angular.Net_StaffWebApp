namespace StaffApp_Api.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
        public string HomeLoc { get; set; }
        public string ManagementLevel { get; set; }
        public string ResourceStatus { get; set; }
        public DateTime RollOffDate { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set; }
        public long ContactDetails { get; set; }
        public DateTime InterviewConductedDate { get; set; }
        public string InterviewConductedBy { get; set; }
        public string Feedback { get; set; }
        public string InterviewStatus { get; set; }
        public string Comments { get; set; }
    }
}



