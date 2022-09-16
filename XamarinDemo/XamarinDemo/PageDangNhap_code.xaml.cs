using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDangNhap_code : ContentPage
    {
        Entry txtttendn, txtmatkhau;

        void TaoGiaoDien()
        {
            //Khai bao layout
            StackLayout lo = new StackLayout();
            // khai bao cac dieu kien
            Label lbltendn = new Label { Text = "ten dang nhap" };
            lo.Children.Add(lbltendn);
            txtttendn = new Entry();
            lo.Children.Add(txtttendn);
            Label lblmatkhau = new Label { Text = "mat khau" };
            lo.Children.Add(lblmatkhau);
            txtmatkhau = new Entry();
            lo.Children.Add(txtmatkhau);
            Button cmddangnhap = new Button { Text = "dang nhap", HorizontalOptions= LayoutOptions.Center };
            lo.Children.Add(cmddangnhap); 
            // nhan += roi bam tab
            cmddangnhap.Clicked += Cmddangnhap_Clicked;
            // them layout cho trang
            this.Content = lo;


        }

        private void Cmddangnhap_Clicked(object sender, EventArgs e)
        {
            string Username, Password;
            Username = txtttendn.Text;
            Password = txtmatkhau.Text;
            if (Username == "Ngocabc" && Password == "123")
            {
                DisplayAlert("Thong bao", "chao ban " + Username, "Dong");

            }
            else
            {
                DisplayAlert("Thong bao", "Thong tin dang nhap sai", "Dong");
            }
        }

        public PageDangNhap_code()
        {
            InitializeComponent();
            TaoGiaoDien();
        }
    }
}