using PartsInfoWebApi.Core.DTOs;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface ID03numberService : IService<D03numbersDto>
    {
        Task<IEnumerable<D03numbersDto>> SearchAsync(string searchTerm);
        Task<D03numbersDto> GetFirstAsync();
        Task<D03numbersDto> GetLastAsync();
        Task<D03numbersDto> GetNextAsync(int currentID);
        Task<D03numbersDto> GetPreviousAsync(int currentID);
        Task<IEnumerable<D03numbersDto>> GetAllSortedAsync();
        Task<(bool success, List<string> changedColumns)> UpdateAsync(D03numbersDto dto);
        Task<(bool success, List<string> changedColumns, string error)> AddOrUpdateAsync(D03numbersDto dto);
        Task SetPositionInformation(IEnumerable<D03numbersDto> dtos);
        Task SetPositionInformation(D03numbersDto dto);
    }
}
