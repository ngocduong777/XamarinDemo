using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLoaiHoa : ContentPage
    {
        Database db;
        LoaiHoa lh;
        public PageLoaiHoa()
        {
            InitializeComponent();
            db = new Database();
            lstdslh1.ItemsSource = db.LayDSLoaiHoa();
        }


        private void lstdslh1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            lh = (LoaiHoa)lstdslh1.SelectedItem;
            Navigation.PushAsync(new PageHoa(lh));
        }
    }
}