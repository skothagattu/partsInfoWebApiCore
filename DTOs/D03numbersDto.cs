using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.DTOs
{
    public class D03numbersDto
    {
        public string ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string BL_NUMBER { get; set; }
        public string PANEL_DWG { get; set; }
        public string WHO { get; set; }
        public string START_DATE { get; set; }
        public string MODEL { get; set; }
        public int Position { get; set; }
        public int Total { get; set; }
    }
}


