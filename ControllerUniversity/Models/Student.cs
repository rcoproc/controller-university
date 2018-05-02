using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30, MinimumLength=2, ErrorMessage = "Nome não pode ser maior que 30 caracteres e nem menor que 1 caracter.")]
        [Display(Name = "Name")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [Display(Name ="Last Name")]
        [StringLength(30, ErrorMessage = "SobreNome não pode ser maior que 30 caracteres")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public string FullName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
