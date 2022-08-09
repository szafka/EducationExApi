namespace EducationExApi.DTO.Review
{
    public class ReviewCreateDTO
    {
        public int ReviewId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ReviewText { get; set; }
        [Required]
        public int MaterialId { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int Rate { get; set; }
    }
}
