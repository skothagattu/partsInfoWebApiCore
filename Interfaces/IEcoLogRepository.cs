using PartsInfoWebApi.Core.Models;
using PartsInfoWebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Core.Interfaces
{
    public interface IEcoLogRepository : IRepository<EcoLog>
    {
        Task<IEnumerable<EcoLog>> SearchAsync(string searchTerm);
        Task<EcoLog> GetFirstAsync();
        Task<EcoLog> GetLastAsync();
        Task<EcoLog> GetNextAsync(int currentNO);
        Task<EcoLog> GetPreviousAsync(int currentNO);
        Task<IEnumerable<EcoLog>> GetAllSortedAsync();
    }
}
