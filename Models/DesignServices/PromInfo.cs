using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Models.DesignServices
{
    [Table("PROMINFO")]
    public class PromInfo
    {
        [Key]
        [Column("PROM NO")]
        public string PromNo { get; set; }

        [Column("LOC A")]
        public string? LocA { get; set; }

        [Column("LOC B")]
        public string? LocB { get; set; }

        [Column("PROM B")]
        public string? PromB { get; set; }

        [Column("LOC C")]
        public string? LocC { get; set; }

        [Column("PROM C")]
        public string? PromC { get; set; }

        [Column("PROM A")]
        public string? PromA { get; set; }

        [Column("LOC D")]
        public string? LocD { get; set; }

        [Column("PROM D")]
        public string? PromD { get; set; }

        public string? Backup { get; set; }
        public string? PLD { get; set; }
        public string? Description { get; set; }

        [Column("REL DATE")]
        public string? RelDate { get; set; }

        public string? Loc { get; set; }

        [Column("TYPE A")]
        public string? TypeA { get; set; }

        [Column("TYPE B")]
        public string? TypeB { get; set; }

        [Column("QTY B")]
        public string? QtyB { get; set; }

        public string? Qty { get; set; }
    }
    [Table("PROMECO")]
    public class PromCurrentEco
    {
        [Key]
        public string ID { get; set; }

        [Column("PROM NO")]
        public string PromNo { get; set; }

        public string? ECO { get; set; }

        [Column("CURRENT REV")]
        public string? CurrentRev { get; set; }

        public string? REV { get; set; }
        public string? DATE { get; set; }
        public string? NOTES { get; set; }
    }
}
