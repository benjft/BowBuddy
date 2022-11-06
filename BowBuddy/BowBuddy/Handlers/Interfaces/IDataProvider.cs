using System.Collections.Generic;
using System.Threading.Tasks;

namespace BowBuddy.Handlers.Interfaces {
    public interface IDataProvider {
        Task RegisterDataType<T>()  where T: new();
        Task<List<T>> GetAll<T>() where T : new();
        Task<List<T>> GetAllWithChildren<T>() where T : new();
        Task<T> Get<T>(object pk) where T : new();
        Task<T> GetWithChildren<T>(object pk) where T : new();
        Task SaveWithChildren<T>(T value);
        Task DeleteRecursive<T>(T value);
    }
}