using PartsInfoWebApi.core.DTOs;
using PartsInfoWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces
{
    public interface ISubLogService : IService<SubLogDto>
    {
        Task<IEnumerable<SubLogDto>> SearchAsync(string searchTerm);
        Task<SubLogDto> GetFirstAsync();
        Task<SubLogDto> GetLastAsync();
        Task<SubLogDto> GetNextAsync(string currentNO);
        Task<SubLogDto> GetPreviousAsync(string currentNO);
        Task<IEnumerable<SubLogDto>> GetAllSortedAsync();
        Task<(bool success, List<string> changedColumns)> UpdateAsync(SubLogDto dto);
        Task SetPositionInformation(IEnumerable<SubLogDto> dtos); // Add this
        Task SetPositionInformation(SubLogDto dto); // Add this
    }


}
