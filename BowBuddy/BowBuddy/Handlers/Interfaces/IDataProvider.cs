using System.Collections.Generic;
using System.Threading.Tasks;

namespace BowBuddy.Handlers.Interfaces {
    public interface IDataProvider {
        Task<List<T>> GetAll<T>() where T : new();
        Task<List<T>> GetAllWithChildren<T>() where T : new();
        Task<T> Get<T>(object pk) where T : new();
        Task<T> GetWithChildren<T>(object pk) where T : new();
        Task GetChildren<T>(T item) where T : new();
        Task Save<T>(T item);
        Task SaveRecursive<T>(T item);
        Task Delete<T>(T item);
        Task DeleteRecursive<T>(T item);
    }
}