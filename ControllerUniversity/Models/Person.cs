using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControllerUniversity.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30,MinimumLength = 2, ErrorMessage = "Name cannot be longer than 30 characters and lower 3 characters.")]
        [Column("FirstName")]
        [Display(Name = "Name")]

        public string FirstMidName { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }
    }
}