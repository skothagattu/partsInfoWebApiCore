using PartsInfoWebApi.core.Models;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface ID03numberRepository : IRepository<D03numbers>
    {
        Task<IEnumerable<D03numbers>> SearchAsync(string searchTerm);
        Task<D03numbers> GetFirstAsync();
        Task<D03numbers> GetLastAsync();
        Task<D03numbers> GetNextAsync(string currentID);
        Task<D03numbers> GetPreviousAsync(string currentID);
        Task<IEnumerable<D03numbers>> GetAllSortedAsync();
    }
}
