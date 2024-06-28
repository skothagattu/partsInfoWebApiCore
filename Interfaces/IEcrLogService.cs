using PartsInfoWebApi.Core.DTOs;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface IEcrLogService : IService<EcrLogDto>
    {
        Task<IEnumerable<EcrLogDto>> SearchAsync(string searchTerm);
        Task<EcrLogDto> GetFirstAsync();
        Task<EcrLogDto> GetLastAsync();
        Task<EcrLogDto> GetNextAsync(int currentNO);
        Task<EcrLogDto> GetPreviousAsync(int currentNO);
        Task<IEnumerable<EcrLogDto>> GetAllSortedAsync();
        Task<(bool success, List<string> changedColumns)> UpdateAsync(EcrLogDto dto);
        Task SetPositionInformation(IEnumerable<EcrLogDto> dtos);
        Task SetPositionInformation(EcrLogDto dto);
    }
}
