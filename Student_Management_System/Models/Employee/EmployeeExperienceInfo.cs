namespace Student_Management_System.Models.Employee
{
    public class EmployeeExperienceInfo
    {
        public int Id { get; set; }
        public int EmployyeId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string JoinDate { get; set; }
        public string LeaveDate { get; set; }
        public string Designation { get; set; }
        public int ServicePeriod { get; set; }
        public string Role { get; set; }
        public string Remarks { get; set; }
        public string EntryBy { get; set; }
        public int EntryDate { get; set; }
        public string UpdateBy { get; set; }
        public int UpdateDate { get; set; }
        
    }
}
