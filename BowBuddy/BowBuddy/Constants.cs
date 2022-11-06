using System;
using System.IO;
using SQLite;

namespace BowBuddy {
    public static class Constants {
        public const string DatabaseFileName = "BowBuddy.sqlite3";
        
        private static string BasePath => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string DatabasePath => Path.Combine(BasePath, DatabaseFileName);
        
        public const SQLiteOpenFlags DatabaseOpenFlags =
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.SharedCache;
    }
}