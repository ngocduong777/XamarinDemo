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
    public partial class PageListViewMang : ContentPage
    {
        void HienThi()
        {
            string[] listHoa = new string[]
            {
                "Hoa cuc", "Hoa cuoi", "Hoa hong", "Hoa xuan"
            };
            dsHoa.ItemsSource = listHoa;
        }
        public PageListViewMang()
        {
            InitializeComponent();
            HienThi();
        }

        private void dsHoa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string loaihoa = (string)dsHoa.SelectedItem.ToString();
            DisplayAlert("Loai hoa", loaihoa, "ok");
        }
    }
}