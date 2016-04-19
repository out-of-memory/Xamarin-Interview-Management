using SQLite;

namespace InterviewManagement
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}