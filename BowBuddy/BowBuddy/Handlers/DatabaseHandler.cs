using System;
using BowBuddy.Handlers.Interfaces;
using SQLite;

namespace BowBuddy.Handlers {
    public class DatabaseHandler : IDataHandler {
        private Lazy<SQLiteAsyncConnection> _databaseConnection =
            new Lazy<SQLiteAsyncConnection>(() =>
                new SQLiteAsyncConnection(Constants.DatabasePath, Constants.DatabaseOpenFlags));
        public DatabaseHandler() { }
    }
}