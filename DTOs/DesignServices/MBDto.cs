using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.DTOs.DesignServices
{
    public class MBDto
    {
        public string DwgNo { get; set; }
        public string RefItem { get; set; }
        public string Size { get; set; }
        public string CutType { get; set; }
        public string QtyPer { get; set; }
        public string Tested { get; set; }
        public string Notes { get; set; }
    }
}
