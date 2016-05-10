using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InterviewManagement
{
    public class SQLiteDatabase : IAuthentication
    {
        private SQLiteConnection databaseConn;

        public SQLiteDatabase()
        {
            databaseConn = DependencyService.Get<ISQLite>().GetConnection();
            databaseConn.CreateTable<User>();
        }

        public bool IsDeviceAuthenticated()
        {
            var user = databaseConn.Query<User>("SELECT * FROM [USER] WHERE AuthToken IS NOT NULL");
            if (user.Count > 0)
                return true;
            else
                return false;
        }

        public bool StoreToken(string token)
        {
            throw new NotImplementedException();
        }

        public bool Login(User user)
        {
            try
            {
                databaseConn.Insert(user);
                return true;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public string GetToken()
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            try
            {
                var userLogout = databaseConn.Query<User>("DELETE FROM [USER]");
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;   
            }
        }
    }

    public interface IAuthentication
    {
        bool IsDeviceAuthenticated();

        bool StoreToken(string token);

        bool Login(User user);

        string GetToken();

        bool Logout();
    }
}
