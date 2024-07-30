using PartsInfoWebApi.core.DTOs.DesignServices;
using PartsInfoWebApi.core.Models.DesignServices;
using PartsInfoWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface ICMIDescRepository : IRepository<CMI_DESC>
    {
        Task<IEnumerable<CMI_DESC>> SearchAsync(string searchTerm, int pageIndex, int pageSize);

    }
}
