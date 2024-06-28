using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.DTOs
{
    public class EcoLogDto
    {
        public int NO { get; set; }
        public string DESC { get; set; }
        public string MODEL { get; set; }
        public string ECR { get; set; }
        public string DATE_LOG { get; set; }
        public string NAME { get; set; }
        public string DATE_REL { get; set; }
        public int Position { get; set; }  // New Property
        public int Total { get; set; }  // New Property
    }
}

