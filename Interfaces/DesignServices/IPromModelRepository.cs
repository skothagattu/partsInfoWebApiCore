using PartsInfoWebApi.core.DTOs.DesignServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface IPromModelRepository
    {
        Task<IEnumerable<PromModelDto>> GetPromModelsByPromNoAsync(int pageIndex, int pageSize);
        Task<IEnumerable<PromModelDto>> GetPromModelsByModelAsync(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsync();
    }
}
