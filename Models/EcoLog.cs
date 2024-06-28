﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartsInfoWebApi.Core.Models
{
    [Table("ECOLOG")]
    public class EcoLog
    {
        [Key]
        public int NO { get; set; }
        [StringLength(50)]
        public string DESC { get; set; }
        [StringLength(50)]
        public string MODEL { get; set; }
        [StringLength(50)]
        public string ECR { get; set; }
        [StringLength(50)]
        public string DATE_LOG { get; set; }
        [StringLength(50)]
        public string NAME { get; set; }
        [StringLength(50)]
        public string DATE_REL { get; set; }
    }
}