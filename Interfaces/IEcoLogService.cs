using PartsInfoWebApi.Core.DTOs;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface IEcoLogService : IService<EcoLogDto>
    {
        Task<IEnumerable<EcoLogDto>> SearchAsync(string searchTerm);
        Task<EcoLogDto> GetFirstAsync();
        Task<EcoLogDto> GetLastAsync();
        Task<EcoLogDto> GetNextAsync(int currentNO);
        Task<EcoLogDto> GetPreviousAsync(int currentNO);
        Task<IEnumerable<EcoLogDto>> GetAllSortedAsync();
        Task SetPositionInformation(IEnumerable<EcoLogDto> dtos);
        Task SetPositionInformation(EcoLogDto dto);
        Task<(bool success, List<string> changedColumns, string error)> AddOrUpdateAsync(EcoLogDto dto);
        Task<(bool success, List<string> changedColumns, string error)> UpdateAsync(EcoLogDto dto);
    }
}
