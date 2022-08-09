namespace EducationExApi.Data.Model.CodecoolDataModel
{
    public class MaterialType
    {
        [Key]
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public ICollection<Material> Materials { get; set; } = new List<Material>();
    }
}