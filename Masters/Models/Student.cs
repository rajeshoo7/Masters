using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        public int NineOneNineNumber { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "First Name")]

      
        public string FirstName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 7)]
        [Display(Name = "Studnet Number")]
        public string Snumber { get; set; }
        public bool done { get; set; }

        public ICollection<DegreePlan> DegreePlans { get; set; }
        public ICollection<StudentTerm> StudentTerms { get; set; }


    }
}
