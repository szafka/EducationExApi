namespace EducationExApi.Data.Model.CodecoolDataModel
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime? PublicationDate { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public MaterialType MaterialType { get; set; }
        public int MaterialTypeId { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }
}