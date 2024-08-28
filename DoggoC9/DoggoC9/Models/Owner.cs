using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoggoC9.Models
{
    public class Owner
    {
        public int Id { get; set; }
     
        [Required(ErrorMessage = "Hmmm... You should really add a Name...")]
        [MaxLength(35)]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(55, MinimumLength = 5)]
        public string Address { get; set; }
        [Phone]

        public string Phone { get; set; }
        [Required]
        [DisplayName("Neighborhood")]
        public int NeighborhoodId { get; set; }
        public Neighborhood neighborhood { get; set; }

    }
}
