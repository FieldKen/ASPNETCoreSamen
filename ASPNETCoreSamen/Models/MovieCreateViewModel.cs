using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreSamen.Models
{
    public class MovieCreateViewModel
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
        [Required, Range(1,10)]
        public int Rating { get; set; }
    }
}