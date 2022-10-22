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
    public partial class PagePicker2 : ContentPage
    {
        List<Country> countries;
        
        void CountryInit()
        {
            countries = new List<Country>();
            countries.Add(new Country ("Tat ca"));
            countries.Add(new Country("Viet Nam"));
            countries.Add(new Country("USA"));
            pickCountry.ItemsSource = countries;
            
        }

        void ListViewCities(string countryName)
        {
            List<City> cities = new List<City>();
            cities.Add(new City { cityImg = "hcm.jpg", cityName = "Ho Chi Minh", countryName = "Viet Nam" });
            cities.Add(new City { cityImg = "hanoi.jpg", cityName = "Ha Noi", countryName = "Viet Nam" });
            cities.Add(new City { cityImg = "danang.jpg", cityName = "Da Nang", countryName = "Viet Nam" });
            cities.Add(new City { cityImg = "LA.jpg", cityName = "Los Angeles", countryName = "USA" });
            cities.Add(new City { cityImg = "NY.jpg", cityName = "New York", countryName = "USA" });
            cities.Add(new City { cityImg = "Miami.jpg", cityName = "Miami", countryName = "USA" });
            if(countryName =="" || countryName=="Tat ca")
            {
                listSelected.ItemsSource = cities;
            }
            else
            {
                List<City> selectedCities = new List<City>();
                foreach(City city in cities)
                {
                    if (city.countryName == countryName)
                    {
                        selectedCities.Add(city);
                    }
                }
                listSelected.ItemsSource = selectedCities;
            }

        }
        public PagePicker2()
        {
            InitializeComponent();
            CountryInit();
            ListViewCities("");
        }



        private void pickCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex >= 0)
            {
                string countryName = picker.Items[selectedIndex].ToString();
                ListViewCities(countryName);
            }
        }
    }
}