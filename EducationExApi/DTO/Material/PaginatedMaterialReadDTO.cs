namespace EducationExApi.DTO.Material
{
    public class PaginatedMaterialReadDTO
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviuos { get; set; }
        public bool HasNext { get; set; }
        public IEnumerable<MaterialReadDTO> Materials { get; set; }
    }
}
