using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH2
{
    public class NganhUIT
    {
        public string tenNganh { get; set; }
        public int maNganh { get; set; }
        public static List<NganhUIT> KhoiTao()
        {
            List<NganhUIT> nganhUITs = new List<NganhUIT>();
            nganhUITs.Add(new NganhUIT { maNganh = 1, tenNganh = "Cong nghe thong tin"});
            nganhUITs.Add(new NganhUIT { maNganh = 2, tenNganh = "He thong thong tin" });
            nganhUITs.Add(new NganhUIT { maNganh = 3, tenNganh = "Khoa hoc may tinh" });
            nganhUITs.Add(new NganhUIT { maNganh = 4, tenNganh = "Ky thuat phan mem" });
            nganhUITs.Add(new NganhUIT { maNganh = 5, tenNganh = "Ky thuat may tinh" });
            nganhUITs.Add(new NganhUIT { maNganh = 6, tenNganh = "Mang may tinh & truyen thong du lieu" });
            nganhUITs.Add(new NganhUIT { maNganh = 7, tenNganh = "An toan thong tin" });
            nganhUITs.Add(new NganhUIT { maNganh = 8, tenNganh = "Thuong mai dien tu" });
            nganhUITs.Add(new NganhUIT { maNganh = 9, tenNganh = "Khoa hoc du lieu" });
            return nganhUITs;





        }
    }
}
