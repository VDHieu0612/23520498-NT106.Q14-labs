using System;
using System.Data.SQLite;
using System.IO;

namespace Lab02
{
    public static class DatabaseHelper
    {
        private static string dbPath = "monan.db";
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                CreateTables();
            }
            return new SQLiteConnection(connectionString);
        }

        private static void CreateTables()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS NguoiDung (
                    IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                    HoVaTen TEXT,
                    QuyenHan TEXT
                );

                CREATE TABLE IF NOT EXISTS MonAn (
                    IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                    TenMonAn TEXT,
                    HinhAnh TEXT,
                    IDNCC INTEGER,
                    FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                );";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
