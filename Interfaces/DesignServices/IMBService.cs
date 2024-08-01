using PartsInfoWebApi.core.DTOs.DesignServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.infrastructure.Repositories.DesignServices
{
    public interface IMBService
    {
        Task<IEnumerable<MBDto>> GetMBDataAsync(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsync();
        Task<IEnumerable<MBDto>> GetMBDataByRefItemAsync(int pageIndex, int pageSize);
        Task<int> GetTotalCountByRefItemAsync();
    }
}
