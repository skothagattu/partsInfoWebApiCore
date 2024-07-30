using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Models
{
    [Table("CABAIREDWGNUMBERS")]
    public class CabAireDWGNumber
    {
        [Key]
        public int NO { get; set; }
        [StringLength(50)]
        public string PREFIX { get; set; }
        [StringLength(50)]
        public string DESC { get; set; }
        [StringLength(50)]
        public string MODEL { get; set; }
        [StringLength(50)]
        public string ORIG { get; set; }
        [StringLength(50)]
        public string DATE { get; set; }
    }
}
