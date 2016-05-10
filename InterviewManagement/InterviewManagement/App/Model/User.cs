using SQLite;

namespace InterviewManagement
{
    public class User
    {
        public User()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string AuthToken { get; set; }
    }
}