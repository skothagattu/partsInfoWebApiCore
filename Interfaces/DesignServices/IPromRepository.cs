using PartsInfoWebApi.core.DTOs.DesignServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface IPromRepository
    {
        Task<IEnumerable<PromListingDto>> GetPromListingAsync(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsync();

    }
}
