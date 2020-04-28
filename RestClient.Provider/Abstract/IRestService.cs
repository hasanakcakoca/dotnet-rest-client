using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestClient.Provider.Abstract
{
    public interface IRestService<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> PostAsync(T entity);
        Task<T> PutAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
