using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Models
{
    public class ThreeLetterCode
    {
        public string? CODE { get; set; }
        public string? TYPE { get; set; }
        public string? COMPANY { get; set; }
        public string? ADDRESS1 { get; set; }
        public string? ADDRESS2 { get; set; }
        public string? CITY_STATE_ZIP { get; set; }
        public string? CONTACT1 { get; set; }
        public string? PHONE1 { get; set; }
        public string? EXT1 { get; set; }
        public string? CONTACT2 { get; set; }
        public string? PHONE2 { get; set; }
        public string? EXT2 { get; set; }
        public string? FAX { get; set; }
        public string? TERMS { get; set; }
        public string? FOB { get; set; }
        public string? NOTES { get; set; }
    }
}

