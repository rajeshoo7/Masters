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
        public int DegreePlanID { get; set; }


      //  [ForeignKey("DegreeID")]
       
        public int DegreeID { get; set; }
        public String StudentID { get; set; }
        public String DegreePlanAbbrev { get; set; }
        public String DegreePlanName { get; set; }
       


    }
}
