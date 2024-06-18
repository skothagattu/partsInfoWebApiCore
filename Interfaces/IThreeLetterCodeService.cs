using PartsInfoWebApi.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Interfaces
{
    public interface IThreeLetterCodeService : IService<ThreeLetterCodeDto>
    {
        Task AddAsync(ThreeLetterCodeDto dto);
        Task<IEnumerable<ThreeLetterCodeDto>> SearchAsync(string searchTerm);
        Task<ThreeLetterCodeDto> GetFirstAsync();
        Task<ThreeLetterCodeDto> GetLastAsync();
        Task<ThreeLetterCodeDto> GetNextAsync(string currentCode);
        Task<ThreeLetterCodeDto> GetPreviousAsync(string currentCode);
        Task<IEnumerable<ThreeLetterCodeDto>> GetAllSortedAsync();
        Task<(bool success, List<string> changedColumns)> UpdateAsync(ThreeLetterCodeDto dto);
        Task SetPositionInformation(IEnumerable<ThreeLetterCodeDto> dtos); // Add this
        Task SetPositionInformation(ThreeLetterCodeDto dto); // Add this
    }
}
