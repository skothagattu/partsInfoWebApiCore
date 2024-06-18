using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInfoWebApi.Interfaces
{
    public interface IService<TDto> where TDto : class
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(object id);
        Task AddAsync(TDto dto);
        Task UpdateAsync(TDto dto);
        Task DeleteAsync(object id);
    }
}
