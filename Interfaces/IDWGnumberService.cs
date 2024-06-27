using PartsInfoWebApi.core.DTOs;
using PartsInfoWebApi.Core.DTOs;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface IDWGnumberService : IService<DWGnumbersDto>
    {
        Task<IEnumerable<DWGnumbersDto>> SearchAsync(string searchTerm);
        Task<DWGnumbersDto> GetFirstAsync();
        Task<DWGnumbersDto> GetLastAsync();
        Task<DWGnumbersDto> GetNextAsync(string currentNO);
        Task<DWGnumbersDto> GetPreviousAsync(string currentNO);
        Task<IEnumerable<DWGnumbersDto>> GetAllSortedAsync();
        Task<(bool success, List<string> changedColumns)> UpdateAsync(DWGnumbersDto dto);
        Task SetPositionInformation(IEnumerable<DWGnumbersDto> dtos); // Add this
        Task SetPositionInformation(DWGnumbersDto dto); // Add this
    }
}
