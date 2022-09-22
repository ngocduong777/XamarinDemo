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
    public partial class PageHinhAnh : ContentPage
    {
        void HienThiHinh()
        {
            for (int i = 1; i <= 16; i++)
            {
                ImageButton h = new ImageButton { Source = "cuc_" + i.ToString() + ".jpg",WidthRequest= 100};
                h.Clicked += H_Clicked;
                fla.Children.Add(h);
            }
        }
        private void H_Clicked (object sender, EventArgs e)
        {
            ImageButton h = (ImageButton)sender;
            Navigation.PushAsync(new PageChitietHinh(h.Source));
        }
        public PageHinhAnh()
        {
            InitializeComponent();
            HienThiHinh();
        }
    }
}