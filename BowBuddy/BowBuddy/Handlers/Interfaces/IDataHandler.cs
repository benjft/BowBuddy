using SQLite;

namespace BowBuddy.Handlers.Interfaces {
    public interface IDataHandler {
        SQLiteAsyncConnection GetAsyncConnection();

        SQLiteConnection GetConnection();
    }
}