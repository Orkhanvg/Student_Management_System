namespace Student_Management_System.Models.Admin
{
    public class UserPermissionDetailsInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        public int EntryBy { get; set; }
        public int EntryDate { get; set; }
        public string UpdateBy { get; set; }
        public int UpdateDate { get; set; }
    }
}
