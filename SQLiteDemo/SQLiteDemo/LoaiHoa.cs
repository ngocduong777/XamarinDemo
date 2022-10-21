using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteDemo
{
    public class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaLoai { get; set; }
        public String TenLoai { get; set; }
        public String Hinh { get; set; }
        public static List<LoaiHoa> KhoiTao()
        {
            List<LoaiHoa> loaiHoas = new List<LoaiHoa>();
            loaiHoas.Add(new LoaiHoa { MaLoai = 1, TenLoai = "Hoa Cúc", Hinh = "cuc_1.jpg" });
            loaiHoas.Add(new LoaiHoa { MaLoai = 2, TenLoai = "Hoa Cưới", Hinh = "cuoi_1.jpg" });
            loaiHoas.Add(new LoaiHoa { MaLoai = 3, TenLoai = "Hoa Hồng", Hinh = "hong_1.jpg" });
            loaiHoas.Add(new LoaiHoa { MaLoai = 4, TenLoai = "Hoa Xuân", Hinh = "xuan_1.jpg" });
            return loaiHoas;

        }

    }
}
