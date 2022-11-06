using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BowBuddy.Handlers.Interfaces;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;

namespace BowBuddy.Handlers {
    public class DatabaseProvider : IDataProvider {
        public DatabaseProvider() { }
        
        private readonly Lazy<SQLiteAsyncConnection> _databaseAsyncConnection =
            new Lazy<SQLiteAsyncConnection>(() =>
                new SQLiteAsyncConnection(Constants.DatabasePath, Constants.DatabaseOpenFlags));
        
        private SQLiteAsyncConnection Database => _databaseAsyncConnection.Value;

        public Task RegisterDataType<T>()  where T: new() =>
            Database.CreateTableAsync<T>();

        public Task<List<T>> GetAll<T>() where T : new() => Database.Table<T>().ToListAsync();

        public Task<List<T>> GetAllWithChildren<T>() where T : new() => Database.GetAllWithChildrenAsync<T>();
        
        public Task<T> Get<T>(object pk) where T : new() =>
            Database.GetAsync<T>(pk);
        
        public Task<T> GetWithChildren<T>(object pk) where T : new() =>
            Database.GetWithChildrenAsync<T>(pk, recursive: true);

        public Task SaveWithChildren<T>(T value) =>
            Database.InsertOrReplaceWithChildrenAsync(value, recursive: true);

        public Task DeleteRecursive<T>(T value) =>
            Database.DeleteAsync(value, recursive: true);
    }
}