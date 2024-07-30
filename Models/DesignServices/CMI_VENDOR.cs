using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Models.DesignServices
{
    public class CMI_VENDOR
    {
        public string ID { get; set; }
        public string CMINO { get; set; }
        public string? CODE { get; set; }
        public string? MFGNO { get; set; }
        public string? SUB { get; set; }
        public DateTime? DATE { get; set; }
        public string? NOTES { get; set; }
    }
}
