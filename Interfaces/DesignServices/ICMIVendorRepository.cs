using PartsInfoWebApi.core.Models.DesignServices;
using PartsInfoWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface ICMIVendorRepository : IRepository<CMI_VENDOR>
    {
        Task<IEnumerable<CMI_VENDOR>> SearchAsync(string searchTerm, int pageIndex, int pageSize);

    }
}
