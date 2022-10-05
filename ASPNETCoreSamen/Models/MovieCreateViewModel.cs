using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreSamen.Models
{
    public class MovieCreateViewModel
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required, Range(1,10)]
        public int Rating { get; set; }
    }
}