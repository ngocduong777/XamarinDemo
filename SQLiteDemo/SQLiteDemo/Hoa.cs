using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace SQLiteDemo
{
    public class Hoa
    {
        [PrimaryKey,AutoIncrement]
        public int MaHoa { get; set; }
        public int MaLoai { get; set; }
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public string MoTa { get; set; }
        public int GiaBan { get; set; }

        public static List<Hoa> KhoiTaoDSHoa()
        {
            List<Hoa> hoas;
            hoas = new List<Hoa>();
            hoas.Add(new Hoa
            {
                MaHoa = 1,
                MaLoai = 1,
                TenHoa = "Hồn nhiên",
                Hinh = "cuc_2.jpg",
                GiaBan = 60000,
                MoTa = "Hoa cúc vàng, cam. lá măng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 2,
                MaLoai = 1,
                TenHoa = "Đón xuân",
                Hinh = "cuc_9.jpg",
                GiaBan = 50000,
                MoTa = "Hoa cúc các màu: trắng, vàng, cam"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 3,
                MaLoai = 1,
                TenHoa = "Tím thuỷ chung",
                Hinh = "cuc_3.jpg",
                GiaBan = 50000,
                MoTa = "Hoa cúc các màu: trắng, vàng, cam"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 4,
                MaLoai = 1,
                TenHoa = "Nét duyên tím hoa cà",
                Hinh = "cuc_4.jpg",
                GiaBan = 40000,
                MoTa = "Hoa cúc màu tím nhạt"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 5,
                MaLoai = 1,
                TenHoa = "Cùng khoe sắc",
                Hinh = "cuc_5.jpg",
                GiaBan = 70000,
                MoTa = "Hoa cúc các màu: trắng, vàng, camHoa cúc màu tím nhạt"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 6,
                MaLoai = 1,
                TenHoa = "Trắng thơ ngây",
                Hinh = "cuc_6.jpg",
                GiaBan = 70000,
                MoTa = "Hoa cúc trắng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 7,
                MaLoai = 2,
                TenHoa = "Dây tơ hồng",
                Hinh = "cuoi_1.jpg",
                GiaBan = 250000,
                MoTa = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá măng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 8,
                MaLoai = 2,
                TenHoa = "Cầu thuỷ tinh",
                Hinh = "cuoi_2.jpg",
                GiaBan = 220000,
                MoTa = "Hoa hồng và hoa thuỷ tiên trắng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 9,
                MaLoai = 2,
                TenHoa = "Duyên thầm",
                Hinh = "cuoi_3.jpg",
                GiaBan = 220000,
                MoTa = "Hoa hồng và hoa thuỷ tiên trắng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 10,
                MaLoai = 2,
                TenHoa = "Đâm chồi nảy lộc",
                Hinh = "cuoi_4.jpg",
                GiaBan = 180000,
                MoTa = "Hoa hồng trắng và các loại lá măng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 11,
                MaLoai = 2,
                TenHoa = "Hoà quyện",
                Hinh = "cuoi_5.jpg",
                GiaBan = 270000,
                MoTa = "Hoa hồng trắng, lá thuỷ tùng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 12,
                MaLoai = 2,
                TenHoa = "Nồng nàn",
                Hinh = "cuoi_6.jpg",
                GiaBan = 210000,
                MoTa = "Hoa hồng đỏ, lá thuỷ tùng, lá măng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 13,
                MaLoai = 3,
                TenHoa = "Together",
                Hinh = "hong_1.jpg",
                GiaBan = 120000,
                MoTa = "Hồng xác pháo, cúc tím"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 14,
                MaLoai = 3,
                TenHoa = "Long trip",
                Hinh = "hong_2.jpg",
                GiaBan = 85000,
                MoTa = "Hoa hồng đỏ, lá kim thuỷ tùng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 15,
                MaLoai = 3,
                TenHoa = "Beautiful life",
                Hinh = "hong_3.jpg",
                GiaBan = 100000,
                MoTa = "Hoa hồng đỏ, lá măng, lá đệm"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 16,
                MaLoai = 3,
                TenHoa = "Morning Sun",
                Hinh = "hong_4.jpg",
                GiaBan = 100000,
                MoTa = "Hoa hồng vàng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 17,
                MaLoai = 3,
                TenHoa = "Pretty Bloom",
                Hinh = "hong_5.jpg",
                GiaBan = 100000,
                MoTa = "Hoa hồng trắng và lá thông"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 18,
                MaLoai = 3,
                TenHoa = "Red Rose",
                Hinh = "hong_7.jpg",
                GiaBan = 100000,
                MoTa = "Hoa hồng đỏ và lá măng"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 19,
                MaLoai = 4,
                TenHoa = "Vấn vương",
                Hinh = "xuan_1.jpg",
                GiaBan = 150000,
                MoTa = "Hoa hồng đỏ, hồng đậm, cúc đỏ, các loại lá"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 20,
                MaLoai = 4,
                TenHoa = "Nắng nhẹ nhàng",
                Hinh = "xuan_2.jpg",
                GiaBan = 250000,
                MoTa = "Hoa cúc xanh, hoa lys vàng, lá đệm"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 21,
                MaLoai = 4,
                TenHoa = "Thanh tao",
                Hinh = "xuan_3.jpg",
                GiaBan = 250000,
                MoTa = "Hoa thủy tiên, cúa trắng, cúc dại tím, các loại lá đệm"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 22,
                MaLoai = 4,
                TenHoa = "Tinh khiết",
                Hinh = "xuan_4.jpg",
                GiaBan = 250000,
                MoTa = "Hồng trắng và salem"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 23,
                MaLoai = 4,
                TenHoa = "Mùa xuân chín",
                Hinh = "xuan_5.jpg",
                GiaBan = 250000,
                MoTa = "Hồmg cam, cúc xanh, thuỷ tiên và các loại lá"
            });
            hoas.Add(new Hoa
            {
                MaHoa = 24,
                MaLoai = 4,
                TenHoa = "Rực rỡ nắng vàng",
                Hinh = "xuan_6.jpg",
                GiaBan = 250000,
                MoTa = "Hồng vàng và cúc vàng"
            });
            return hoas;
        }

    }
}

