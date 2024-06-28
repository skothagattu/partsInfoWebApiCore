using PartsInfoWebApi.Core.Models;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface IEcrLogRepository : IRepository<EcrLog>
    {
        Task<IEnumerable<EcrLog>> SearchAsync(string searchTerm);
        Task<EcrLog> GetFirstAsync();
        Task<EcrLog> GetLastAsync();
        Task<EcrLog> GetNextAsync(int currentNO);
        Task<EcrLog> GetPreviousAsync(int currentNO);
        Task<IEnumerable<EcrLog>> GetAllSortedAsync();
    }
}
