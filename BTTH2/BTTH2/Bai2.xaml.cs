using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai2 : ContentPage
    {
        public Bai2()
        {
            InitializeComponent();
            KhoitaoListCity();
        }
        List<City> listcity = new List<City>();
        private void KhoitaoListCity()
        {
            listcity.Add(new City { citycode = 1, cityimage = "hanoi.jpg",cityname="Hà Nội" });
            listcity.Add(new City { citycode = 2, cityimage = "hcm.jpg", cityname = "Hồ Chí Minh" });
            listcity.Add(new City { citycode = 3, cityimage = "dalat.jpg", cityname = "Đà Lạt" });
            listcity.Add(new City { citycode = 4, cityimage = "danang.jpg", cityname = "Đà Nẵng" });
            listCity.ItemsSource = listcity;
        }
        private void listCity_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender != null)
            {
                City location = (City)listCity.SelectedItem;
                Navigation.PushAsync(new PageHotel(location));
            }
        }
    }
}