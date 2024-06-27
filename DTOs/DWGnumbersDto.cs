using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.DTOs
{
    public class DWGnumbersDto
    {
        public string PREFIX { get; set; }
        public string NO { get; set; }
        public string DESC { get; set; }
        public string MODEL { get; set; }
        public string ORIG { get; set; }
        public string DATE { get; set; }
        public int Position { get; set; }  // New Property
        public int Total { get; set; }  // New Property
    }
}
