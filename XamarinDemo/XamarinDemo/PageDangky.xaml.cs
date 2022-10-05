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
    public partial class PageDangky : ContentPage
    {
        public PageDangky()
        {
            InitializeComponent();
        }

        private void txtnoisinh_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", txtnoisinh.Text, "Thông báo");
        }

        private void slthunhap_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblthunhap.Text = slthunhap.Value.ToString();
        }

        private void cmddangky_Clicked(object sender, EventArgs e)
        {
            string info="";
            info += "Ho ten: " + txthoten.Text + "\n";
            info += "Thu nhap: " + slthunhap.Value.ToString()+ "\n";
            info += "Ngay sinh: " + datepickerBirthday.Date.ToString("dd/mm/yyyy")+"\n";
            info += "Gio" + thoigiandangki.Time.ToString()+"\n";
            if (swgioitinh.IsToggled)
            {
                info += "Male";
            }
            else
            {
                info += "Female";
            }
            
            DisplayAlert("Thong bao", info, "ok");
            tientrinh.IsRunning = false;
            progresstientrinh.Progress += 0.3;
        }

        private void cmddangnhap_Clicked(object sender, EventArgs e)
        {

        }

        private void stepperAge_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblage.Text = stepperAge.Value.ToString();
        }

        private void datepickerBirthday_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}