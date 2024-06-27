using PartsInfoWebApi.core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Interfaces
{
    public interface IThreeLetterCodeRepository : IRepository<ThreeLetterCode>
    {
        Task<IEnumerable<ThreeLetterCode>> SearchAsync(string searchTerm);
        Task<ThreeLetterCode> GetFirstAsync();
        Task<ThreeLetterCode> GetLastAsync();
        Task<ThreeLetterCode> GetNextAsync(string currentCode);
        Task<ThreeLetterCode> GetPreviousAsync(string currentCode);
        Task<IEnumerable<ThreeLetterCode>> GetAllSortedAsync();
    }
}
