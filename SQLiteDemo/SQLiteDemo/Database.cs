using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace SQLiteDemo
{
    public class Database
    {
        String Duongdan = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public bool CreateDB()
        {
            try
            {
                var Connection = new SQLiteConnection(System.IO.Path.Combine(Duongdan, "qlbanhoa.db"));
                Connection.CreateTable<LoaiHoa>();
                Connection.CreateTable<Hoa>();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertLoaiHoa(LoaiHoa lh)
        {
            try
            {
                var Connection = new SQLiteConnection(System.IO.Path.Combine(Duongdan, "qlbanhoa.db"));
                Connection.Insert(lh);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateLoaiHoa(LoaiHoa lh)
        {
            try
            {
                var Connection = new SQLiteConnection(System.IO.Path.Combine(Duongdan, "qlbanhoa.db"));
                Connection.Update(lh);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteLoaiHoa(LoaiHoa lh)
        {
            try
            {
                var Connection = new SQLiteConnection(System.IO.Path.Combine(Duongdan, "qlbanhoa.db"));
                Connection.Delete(lh);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LoaiHoa> LayDSLoaiHoa()
        {
            try
            {
                var Connection = new SQLiteConnection(System.IO.Path.Combine(Duongdan, "qlbanhoa.db"));

                return Connection.Table<LoaiHoa>().ToList();
            }
            catch
            {
                return null;
            }
        }


        public bool InsertHoa(Hoa h)
        {
            try
            {
                var Connection = new SQLiteConnection(System.IO.Path.Combine(Duongdan, "qlbanhoa.db"));
                Connection.Insert(h);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Hoa> LayDSHoaTheoLoai(LoaiHoa lh)
        {
            try
            {
                string Caulenh = "select * from hoa where maloai="+lh.MaLoai.ToString();
                var connection = new SQLiteConnection(System.IO.Path.Combine(Duongdan, "qlbanhoa.db"));
                return connection.Query<Hoa>(Caulenh);
                
            }
            catch
            {
                return null;
            }
        }
    }
}
