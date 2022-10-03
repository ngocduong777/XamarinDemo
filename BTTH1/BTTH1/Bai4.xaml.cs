using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai4 : ContentPage
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            string txtName = this.txtname.Text;
            string txtEmail = this.txtemail.Text;
            var dpBirthday = this.dpBirthday.Date.ToShortDateString();
            var swtGender = this.SwtGender.IsToggled;
            if(string.IsNullOrWhiteSpace(txtName) || string.IsNullOrWhiteSpace(txtEmail))
            {
                DisplayAlert("Warning", "Please do not leave it blank", "OK");
            }
            else
            {
                string gender = "";
                if (swtGender)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                var message = "Name: " + txtName + "\nEmail: " + txtEmail + "\nBirthday: " + dpBirthday + "\nGender: " + gender + "\nAge: "+ ageSlider.Value.ToString();
                DisplayAlert("User info", message, "OK");
            }
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {

            clearText();
        }
        private void clearText()
        {
            this.txtname.Text = "";
            this.txtemail.Text = "";
            this.dpBirthday.Date = DateTime.Now;
            this.SwtGender.IsToggled = false;
        }

        private void ageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ageSliderLabel.Text = "Age: "+ ageSlider.Value.ToString();
            

        }
    }
}