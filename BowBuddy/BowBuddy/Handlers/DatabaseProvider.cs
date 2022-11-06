using System.Collections.Generic;
using System.Threading.Tasks;
using BowBuddy.Handlers.Interfaces;
using BowBuddy.Helpers;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;

namespace BowBuddy.Handlers {
    public class DatabaseProvider : IDataProvider {
        private readonly SQLiteAsyncConnection _databaseAsyncConnection;
        
        public DatabaseProvider() {
            _databaseAsyncConnection = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.DatabaseOpenFlags);
            CreateTablesForModels();
        }

        private void CreateTablesForModels() {
            var methodInfo = typeof(SQLiteAsyncConnection).GetMethod(nameof(SQLiteAsyncConnection.CreateTableAsync));
            foreach (var type in ModelHelper.ModelTypes) {
                methodInfo!.MakeGenericMethod(type).Invoke(_databaseAsyncConnection, null);
            }
        }

        public Task<List<T>> GetAll<T>() where T : new() => 
            _databaseAsyncConnection.Table<T>().ToListAsync();

        public Task<List<T>> GetAllWithChildren<T>() where T : new() => 
            _databaseAsyncConnection.GetAllWithChildrenAsync<T>();
        
        public Task<T> Get<T>(object pk) where T : new() =>
            _databaseAsyncConnection.GetAsync<T>(pk);
        
        public Task<T> GetWithChildren<T>(object pk) where T : new() =>
            _databaseAsyncConnection.GetWithChildrenAsync<T>(pk, recursive: true);

        public Task GetChildren<T>(T item) where T : new() => 
            _databaseAsyncConnection.GetChildrenAsync(item, recursive: true);
        
        public Task Save<T>(T item) => 
            _databaseAsyncConnection.InsertOrReplaceAsync(item);
        
        public Task SaveRecursive<T>(T item) =>
            _databaseAsyncConnection.InsertOrReplaceWithChildrenAsync(item, recursive: true);

        public Task Delete<T>(T item) => _databaseAsyncConnection.DeleteAsync(item);
        
        public Task DeleteRecursive<T>(T item) =>
            _databaseAsyncConnection.DeleteAsync(item, recursive: true);
    }
}