using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdStacklayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void cmddangnhap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDangNhap());
        }

        private void cmddangnhapCode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDangNhap_code());

        }

        private void cmdHinh_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageHinhAnh());
        }

        private void cmddangnhapgrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDangNhapGrid());

        }

        private void cmdBangtinh_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMaytinh());

        }
    }
}
