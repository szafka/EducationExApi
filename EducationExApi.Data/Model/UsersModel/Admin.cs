namespace EducationExApi.Data.Model.UsersModel
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
