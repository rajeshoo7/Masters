using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Degree ID")]
        public int DegreeId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Abbreviation")]
        public string DegreeAbrrev { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        [Display(Name = "Name")]
        public string DegreeName { get; set; }

        public bool done { get; set; }
        public ICollection<DegreeRequirement> DegreeRequirements { get; set; }
    }
}
