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
    public partial class PageLoaiHoa : ContentPage
    {
        public PageLoaiHoa()
        {
            InitializeComponent();
            lstdslh.ItemsSource = LoaiHoa.KhoiTao();
        }

        private void lstdslh_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LoaiHoa lh = (LoaiHoa)lstdslh.SelectedItem;
            Navigation.PushAsync(new PageHoa(lh));
        }
    }
}