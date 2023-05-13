namespace Student_Management_System.Models.Student
{
    public class StudentSectionInfo
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int ShiftId { get; set; }
        public int SectionCode { get; set; }
        public string SectionName { get; set; }
        public string EntryBy { get; set; }
        public int EntryDate { get; set; }
        public string UpdateBy { get; set; }
        public int UpdateDate { get; set; }

    }
}
