namespace EducationExApi.DTO.MaterialType
{
    public class MaterialTypePatchDTO
    {
        [Required]
        [MaxLength(20)]
        public string? Type { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Description { get; set; }
    }
}
