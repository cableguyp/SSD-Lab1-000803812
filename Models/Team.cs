using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; } = "";

        [Required, Display(Name = "Email"), DataType(DataType.EmailAddress)]
        public string Email { get; set; } = "";

        [DataType(DataType.Date)]
        [Display(Name = "Established Date")]
        public DateTime? EstablishedDate { get; set; }
    }
}
