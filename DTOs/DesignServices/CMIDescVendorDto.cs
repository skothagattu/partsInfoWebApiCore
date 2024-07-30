using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.DTOs.DesignServices
{
    public class CMIDescVendorDto
    {
        public string CMINO { get; set; }
        public string DESCRIPTION { get; set; }
        public string? CODE { get; set; }
        public string? MFGNO { get; set; }
        public string? SUB { get; set; }
        public DateTime? DATE { get; set; }
        public string? NOTES { get; set; }
    }
}
