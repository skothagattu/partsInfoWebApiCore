using PartsInfoWebApi.core.Models.DesignServices;
using PartsInfoWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface IStdPartIndexRepository : IRepository<StdPartIndex>
    {
        Task<IEnumerable<StdPartIndex>> GetStdPartIndexesAsync(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsync();
        Task<IEnumerable<StdPartIndex>> GetStdPartIndexesAsyncByTitle(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsyncByTitle();
    }
}
