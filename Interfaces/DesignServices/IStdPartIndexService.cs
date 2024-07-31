using PartsInfoWebApi.core.DTOs.DesignServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface IStdPartIndexService
    {
        Task<IEnumerable<StdPartIndexDto>> GetStdPartIndexesAsync(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsync();
        Task<IEnumerable<StdPartIndexDto>> GetStdPartIndexesAsyncByTitle(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsyncByTitle();
    }
}
