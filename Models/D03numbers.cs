using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartsInfoWebApi.core.Models
{
    [Table("D03NUMBERS")]
    public class D03numbers
    {
        [Key]
        [Column("ID")]
        [StringLength(50)]
        public string ID { get; set; }

        [Column("DESCRIPTION")]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [Column("BL_NUMBER")]  // Note the spaces in the actual column name
        [StringLength(50)]
        public string BL_NUMBER { get; set; }

        [Column("PANEL_DWG")]  // Note the spaces in the actual column name
        [StringLength(50)]
        public string PANEL_DWG { get; set; }

        [Column("WHO")]
        [StringLength(50)]
        public string WHO { get; set; }

        [Column("START_DATE")]  // Note the spaces in the actual column name
        [StringLength(50)]
        public string START_DATE { get; set; }

        [Column("MODEL")]
        [StringLength(50)]
        public string MODEL { get; set; }
    }
}
