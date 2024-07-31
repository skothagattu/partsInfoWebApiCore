using PartsInfoWebApi.core.DTOs.DesignServices;
using PartsInfoWebApi.core.Models.DesignServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces.DesignServices
{
    public interface IDesignService
    {
/*        Task<IEnumerable<CMI_DESC>> GetCMIDescsAsync(int pageIndex, int pageSize);
        Task<IEnumerable<CMI_VENDOR>> GetCMIVendorsAsync(int pageIndex, int pageSize);*/
        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorDataAsync(int pageIndex, int pageSize);
        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorByMfgNoAsync(int pageIndex, int pageSize);
        Task<int> GetTotalCountAsync(); // Add this line
        Task<int> GetTotalCountByMfgNoAsync();

        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorByDateAsync(DateTime date, int pageIndex, int pageSize);
        Task<int> GetTotalCountByDateAsync(DateTime date);

        Task<IEnumerable<CMIDescVendorDto>> GetCMIDescVendorByDateAsyncMfgNo(DateTime date, int pageIndex, int pageSize);
        Task<int> GetTotalCountByDateAsyncMfgNo(DateTime date);
    }
}
