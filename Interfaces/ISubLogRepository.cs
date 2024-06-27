using PartsInfoWebApi.core.Models;
using PartsInfoWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.core.Interfaces
{
    public interface ISubLogRepository : IRepository<SubLog>
    {
        Task<IEnumerable<SubLog>> SearchAsync(string searchTerm);
        Task<SubLog> GetFirstAsync();
        Task<SubLog> GetLastAsync();
        Task<SubLog> GetNextAsync(string currentNO);
        Task<SubLog> GetPreviousAsync(string currentNO);
        Task<IEnumerable<SubLog>> GetAllSortedAsync();
    }

}
