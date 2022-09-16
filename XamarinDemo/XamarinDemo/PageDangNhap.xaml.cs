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
    public partial class PageDangNhap : ContentPage
    {
        public PageDangNhap()
        {
            InitializeComponent();
        }

        private void cmddangnhap_Clicked(object sender, EventArgs e)
        {
            string Username, Password;
            Username = txttendn.Text;
            Password = txtmatkhau.Text;
            if(Username=="Ngoc" && Password == "123")
            {
                DisplayAlert("Thong bao", "chao ban " + Username, "Dong");

            }
            else
            {
                DisplayAlert("Thong bao", "Thong tin dang nhap sai", "Dong");
            }
        }
    }
}