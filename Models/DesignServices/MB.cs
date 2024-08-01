using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Models.DesignServices
{
    [Table("MB")]
    public class MB
    {
        [Key]
        public string ID { get; set; }

        [Column("DWGNO")]
        public string DwgNo { get; set; }

        [Column("REFITEM")]
        public string RefItem { get; set; }

        public string SIZE { get; set; }
        public string TYPE { get; set; }
        public string DESCRIPTION { get; set; }
        public string LOCATION { get; set; }
        public string MATLUSED { get; set; }

        [Column("ORIGNO")]
        public string OrigNo { get; set; }

        [Column("CUTTYPE")]
        public string CutType { get; set; }

        [Column("QTYPER")]
        public string QtyPer { get; set; }

        public string TESTED { get; set; }
        public string NOTES { get; set; }
    }
}
