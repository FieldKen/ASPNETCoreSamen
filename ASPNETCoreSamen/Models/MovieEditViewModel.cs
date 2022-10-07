using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASPNETCoreSamen.Models
{
    public class MovieEditViewModel
    {
        [DisplayName("Titel van de film")]
        [Required, MinLength(3), MaxLength(50)]
        public string Title { get; set; }
        [DisplayName("Geef een beschrijving")]
        public string Description { get; set; }
        [DisplayName("Genre van de film")]
        [Required]
        public string Genre { get; set; }
        [DisplayName("Geef de film een leuke rating")]
        [Required, Range(1, 10)]
        public int Rating { get; set; }
    }
}
