using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Models.DesignServices
{
    [Table("STDPARTINDEX")]
    public class StdPartIndex
    {
        [Key]
        [Column("NUMBER")]
        public string Number { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }
    }
}
