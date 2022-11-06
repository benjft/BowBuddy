using System;
using BowBuddy.Handlers.Interfaces;
using SQLite;

namespace BowBuddy.Handlers {
    public class DatabaseHandler : IDataHandler {
        private readonly Lazy<SQLiteAsyncConnection> _databaseAsyncConnection =
            new Lazy<SQLiteAsyncConnection>(() =>
                new SQLiteAsyncConnection(Constants.DatabasePath, Constants.DatabaseOpenFlags));

        private readonly Lazy<SQLiteConnection> _databaseConnection =
            new Lazy<SQLiteConnection>(() => 
                new SQLiteConnection(Constants.DatabasePath, Constants.DatabaseOpenFlags)); 
        
        public SQLiteAsyncConnection GetAsyncConnection() => _databaseAsyncConnection.Value;
        
        public SQLiteConnection GetConnection() => _databaseConnection.Value;

        public DatabaseHandler() { }
    }
}