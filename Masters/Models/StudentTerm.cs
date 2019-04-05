using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
         public int StudentTermId { get; set; }
         public int StudentId { get; set; }
        public int TermId { get; set; }
        public string TermAbbrev { get; set; }
        public string TermLabel { get; set; }

        public Student Student { get; set; }
        public bool done { get; set; }
    }
}
