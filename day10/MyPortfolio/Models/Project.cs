using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("프로젝트명")]
        public string ProjectName { get; set; }

        [Required]
        [MaxLength(400)]
        [DisplayName("프로젝트설명")]
        public string Description { get; set; }

        // 300X500 or 600 이미지      
        public string? FilePath { get; set; }
    }
}
