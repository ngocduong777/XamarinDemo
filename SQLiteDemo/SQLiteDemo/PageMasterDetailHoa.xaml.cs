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
    public partial class PageMasterDetailHoa : MasterDetailPage
    {
        Database db;
        public PageMasterDetailHoa()
        {
            InitializeComponent();
            db = new Database();
            lstdslh.ItemsSource = db.LayDSLoaiHoa();
            IsPresented = true;
            
        }

        private void lstdslh_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LoaiHoa lh = (LoaiHoa)lstdslh.SelectedItem;
            lbltenloai.Text = lh.TenLoai;
            lsthoa.ItemsSource = db.LayDSHoaTheoLoai(lh);
            IsPresented = false;
        }

        private void lsthoa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void cmdMaster_Clicked(object sender, EventArgs e)
        {
            IsPresented = true;
        }
    }
}