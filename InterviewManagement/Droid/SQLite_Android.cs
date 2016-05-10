using InterviewManagement.Droid;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]

namespace InterviewManagement.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
        }

        #region ISQLite_Implementation

        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "InterviewManagementDB.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);

            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                var s = Forms.Context.Resources.OpenRawResource(Resource.Raw.InterviewManagementDB);

                FileStream writeStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                ReadWriteStream(s, writeStream);
            }

            var conn = new SQLiteConnection(path);
            return conn;
        }

        #endregion

        private void ReadWriteStream(Stream readStream, FileStream writeStream)
        {
            int Length = 256;
            Byte[] buffer = new Byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            // write the required bytes
            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, Length);
                bytesRead = readStream.Read(buffer, 0, Length);
            }
            readStream.Close();
            writeStream.Close();
        }
    }
}