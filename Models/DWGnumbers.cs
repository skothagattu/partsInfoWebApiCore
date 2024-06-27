using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartsInfoWebApi.Core.Models
{
    [Table("DWGNUMBERS")]
    public class DWGnumbers
    {
        [Key]
        [StringLength(50)]
        public string PREFIX { get; set; }
        [StringLength(50)]
        public string NO { get; set; }
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
