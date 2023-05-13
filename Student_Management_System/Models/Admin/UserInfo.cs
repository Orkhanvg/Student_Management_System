namespace Student_Management_System.Models.Admin
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string IsActive { get; set; }
        public string EntryBy { get; set; }
        public string EntryDate  { get; set; }
        public string UpdateBy { get; set; }
        public int UpdateDate { get; set; }

    }
}
