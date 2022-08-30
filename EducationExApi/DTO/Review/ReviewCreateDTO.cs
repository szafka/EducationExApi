namespace EducationExApi.DTO.Review
{
    public class ReviewCreateDTO
    {
        [Required]
        [MaxLength(50)]
        public string ReviewText { get; set; }
        [Required]
        public int MaterialId { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Type range from 1 to 10")]
        public int Rate { get; set; }
    }
}
