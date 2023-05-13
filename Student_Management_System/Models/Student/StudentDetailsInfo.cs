namespace Student_Management_System.Models.Student
{
    public class StudentDetailsInfo
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ShiftId { get; set; }
        public int RollNo { get; set; }
        public int ClassId { get; set; }
        public int GroupId { get; set; }
        public int SectionId  { get; set; }
        public string Session { get; set; }
        public string EntryBy { get; set; }
        public int EntryDate { get; set; }
        public string UpdateBy { get; set; }
        public int UpdateDate { get; set; }
        
    }
}
