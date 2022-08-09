using System.ComponentModel.DataAnnotations.Schema;

namespace EducationExApi.DTO.Material
{
    public class MaterialReadDTO
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? PublicationDate { get; set; }
    }
}
