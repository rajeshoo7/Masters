using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Models
{
    public class StudentTerm
    {

        public int StudentID { get; set; }
        public int StudentTermID { get; set; }
        public int TermID { get; set; }
        public string TermAbbrev { get; set; }
        public string TermLabel { get; set; }
    }
}
