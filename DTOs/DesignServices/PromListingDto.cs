using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.DTOs.DesignServices
{
    public class PromListingDto
    {
        public string PromNo { get; set; }
        public string? Rev { get; set; }
        public string? Description { get; set; }
        public string? Loc { get; set; }
        public string? TypeA { get; set; }
        public string? Qty { get; set; }
        public string? TypeB { get; set; }
        public string? QtyB { get; set; }
    }
}
