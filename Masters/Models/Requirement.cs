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
        public int RequirementId { get; set; }
        public string RequirementAbbrev { get; set; }
        public string RequirementName { get; set; }
        public bool done { get; set; }


    }
}
