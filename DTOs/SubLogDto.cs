using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.DTOs
{
public class SubLogDto
{
    public string NO { get; set; }
    public string PART_NO { get; set; }
    public string DESC { get; set; }
    public string REQ_BY { get; set; }
    public string REQ_DATE { get; set; }
    public string ASSIGN { get; set; }
    public string ACCEPT { get; set; }
    public string REJECT { get; set; }
    public string DATE { get; set; }
    public int Position { get; set; }  // New Property
    public int Total { get; set; }  // New Property
    }

}
