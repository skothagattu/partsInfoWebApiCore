using PartsInfoWebApi.Core.Models;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface IDWGnumberRepository : IRepository<DWGnumbers>
    {
        Task<IEnumerable<DWGnumbers>> SearchAsync(string searchTerm);
        Task<DWGnumbers> GetFirstAsync();
        Task<DWGnumbers> GetLastAsync();
        Task<DWGnumbers> GetNextAsync(string currentNO);
        Task<DWGnumbers> GetPreviousAsync(string currentNO);
        Task<IEnumerable<DWGnumbers>> GetAllSortedAsync();
    }
}
