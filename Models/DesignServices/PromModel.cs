using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Models.DesignServices
{
    [Table("PROMMODEL")]
    public class PromModel
    {
        [Key]
        [Column("PROMNO")]
        public string PromNo { get; set; }

        [Column("MODEL")]
        public string Model { get; set; }
    }
}
