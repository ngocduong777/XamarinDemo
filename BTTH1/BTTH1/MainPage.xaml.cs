using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai1());

        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai2());
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai3());
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai4());
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {

        }
    }
}
