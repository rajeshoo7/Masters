using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Models
{
    public class DegreePlan
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }


      //  [ForeignKey("DegreeId")]
       
        public int DegreeId { get; set; }
        public String StudentId { get; set; }
        public String DegreePlanAbbrev { get; set; }
        public String DegreePlanName { get; set; }

        public Degree Degree { get; set; }
       
       


    }
}
