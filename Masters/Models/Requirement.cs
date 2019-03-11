using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Models
{
    public class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequirementID { get; set; }
        public string RequirementAbbrev { get; set; }
        public string RequirementName { get; set; }


    }
}
