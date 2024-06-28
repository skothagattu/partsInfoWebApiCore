using PartsInfoWebApi.Core.DTOs;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface ICabAireDWGNumberService : IService<CabAireDWGNumberDto>
    {
        Task<IEnumerable<CabAireDWGNumberDto>> SearchAsync(string searchTerm);
        Task<CabAireDWGNumberDto> GetFirstAsync();
        Task<CabAireDWGNumberDto> GetLastAsync();
        Task<CabAireDWGNumberDto> GetNextAsync(int currentNO);
        Task<CabAireDWGNumberDto> GetPreviousAsync(int currentNO);
        Task<IEnumerable<CabAireDWGNumberDto>> GetAllSortedAsync();
        Task SetPositionInformation(IEnumerable<CabAireDWGNumberDto> dtos);
        Task SetPositionInformation(CabAireDWGNumberDto dto);
        Task<(bool success, List<string> changedColumns)> UpdateAsync(CabAireDWGNumberDto dto);  // Ensure this is defined
    }

}
