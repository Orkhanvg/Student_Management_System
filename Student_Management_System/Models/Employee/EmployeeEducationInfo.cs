namespace Student_Management_System.Models.Employee
{
    public class EmployeeEducationInfo
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string DegreeName { get; set; }
        public string InstituteName { get; set; }
        public string GroupOrSubject { get; set; }
        public string ClassOrGrade { get; set; }
        public int PassingYear { get; set; }
        public string BoardOrUniversity { get; set; }
        public string EntryBy { get; set; }
        public int EntryDate { get; set; }
        public string UpdateBy { get; set; }
        public int UpdateDate { get; set; }

    }
}
