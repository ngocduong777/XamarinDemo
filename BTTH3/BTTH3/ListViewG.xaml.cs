using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewG : ContentPage
    {
        List<Country> CountryList;
        void CountryInit()
        {
            CountryList = new List<Country>();
            Country Vietnam = new Country("Viet Nam") { description = "Asia" };
            Vietnam.Add(new City { cityName = "Ho Chi Minh City", cityImg = "hcm.jpg" });
            Vietnam.Add(new City { cityName = "Ha Noi", cityImg = "hanoi.jpg" });
            Vietnam.Add(new City { cityName = "Da Nang", cityImg = "danang.jpg" });

            CountryList.Add(Vietnam);

            Country USA = new Country("United State") { description = "Nuoc My Dieu Ky" }; ;
            USA.Add(new City { cityName = "New York", cityImg = "NY.jpg" });
            USA.Add(new City { cityName = "Los Angeles", cityImg = "LA.jpg" });
            USA.Add(new City { cityName = "Miami", cityImg = "Miami.jpg" });
            CountryList.Add(USA);

        }
        public ListViewG()
        {
            InitializeComponent();
            CountryInit();
            listCountry.ItemsSource = CountryList;
            
        }
    }
}