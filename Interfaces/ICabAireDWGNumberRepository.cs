using PartsInfoWebApi.core.Models;
using PartsInfoWebApi.Core.Models;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface ICabAireDWGNumberRepository : IRepository<CabAireDWGNumber>
    {
        Task<IEnumerable<CabAireDWGNumber>> SearchAsync(string searchTerm);
        Task<CabAireDWGNumber> GetFirstAsync();
        Task<CabAireDWGNumber> GetLastAsync();
        Task<CabAireDWGNumber> GetNextAsync(int currentNO);
        Task<CabAireDWGNumber> GetPreviousAsync(int currentNO);
        Task<IEnumerable<CabAireDWGNumber>> GetAllSortedAsync();
    }
}
