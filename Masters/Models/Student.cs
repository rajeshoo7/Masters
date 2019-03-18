using System;
using System.Collections.Generic;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Snumber { get; set; }

        //public ICollection<DegreePlan> DegreePlans { get; set; }
        //public ICollection<StudentTerm> StudentTerms { get; set; }


    }
}
