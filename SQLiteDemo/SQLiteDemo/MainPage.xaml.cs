using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteDemo
{
    
    public partial class MainPage : ContentPage
    {
        Database db;
        LoaiHoa lh;

        void HienThiDSLoaiHoa()
        {
            List<LoaiHoa> dslh = db.LayDSLoaiHoa();
            lstdslh.ItemsSource = dslh;
            if (dslh.Count > 0)
            {
                lstdslh.SelectedItem = dslh[0];
            }
        }
        void HienThi()
        {
            txtmalh.Text = lh.MaLoai.ToString();
            txttenlh.Text = lh.TenLoai;
            txthinhlh.Text = lh.Hinh;

        }
        public MainPage()
        {
            InitializeComponent();
            db = new Database();
        /*Them 1 lan thoi*/
           /* try
            {
                db = new Database();
                foreach (LoaiHoa lh in LoaiHoa.KhoiTao())
                    db.InsertLoaiHoa(lh);
                DisplayAlert("Thong bao", "Them loai hoa thanh cong", "OK");
            }
            catch
            {
                DisplayAlert("Thong bao", "Them hoa that bai", "OK");
            }*/

            HienThiDSLoaiHoa();
        }

        private void lstdslh_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            lh = (LoaiHoa)lstdslh.SelectedItem;
            HienThi();
        }

        private void cmdthem_Clicked(object sender, EventArgs e)
        {
            lh = new LoaiHoa { MaLoai = 0 };
            HienThi();
            txttenlh.Focus();
        }

        private void cmdghi_Clicked(object sender, EventArgs e)
        {
            bool kq = false;
            lh.TenLoai = txttenlh.Text;
            lh.Hinh = txthinhlh.Text;
            if (lh.MaLoai > 0)
                kq = db.UpdateLoaiHoa(lh);
            else
                kq = db.InsertLoaiHoa(lh);

            if (kq == true)
            {
                DisplayAlert("Thong bao", "Cap nhat thanh cong", "OK");
                HienThiDSLoaiHoa();
            }
            else
                DisplayAlert("Thong bao", "Cap nhat that bai", "OK");
        }

        private void cmdkhong_Clicked(object sender, EventArgs e)
        {
            if (lstdslh.SelectedItem != null)
            {
                lh = (LoaiHoa)lstdslh.SelectedItem;

            }
            HienThi();
        }

        private async void cmdxoa_Clicked(object sender, EventArgs e)
        {
            bool kq = await DisplayAlert("Thong bao","Xoa khong?", "Um", "Khong");
            lh = (LoaiHoa)lstdslh.SelectedItem;
            if (kq == true)
            {
                if (db.DeleteLoaiHoa(lh) == true)
                {
                    await DisplayAlert("Thong bao", "Xoa thanh cong", "OK");
                    HienThiDSLoaiHoa();
                }
                else
                {
                    await DisplayAlert("Thong bao", "Xoa that bai", "OK");
                    
                }

            }
        }
    }
}
