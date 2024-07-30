using PartsInfoWebApi.core.DTOs.DesignServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface ICMIDescVendorRepository
    {
        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorDataAsync(int pageIndex, int pageSize);
        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorByMfgNoAsync(int pageIndex, int pageSize);
        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorByDateAsync(DateTime date, int pageIndex, int pageSize);
        Task<int> GetTotalCountByDateAsync(DateTime date);
        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorByDateAsyncMfgNo(DateTime date, int pageIndex, int pageSize);
        Task<int> GetTotalCountByDateAsyncMfgNo(DateTime date);
        Task<int> GetTotalCountAsync();
        Task<int> GetTotalCountByMfgNoAsync();
    }
}
