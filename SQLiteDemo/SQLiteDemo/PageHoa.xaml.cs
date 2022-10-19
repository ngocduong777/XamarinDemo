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
    public partial class PageHoa : ContentPage
    {
        Database db;
        public PageHoa()
        {
            InitializeComponent();

        }

        public PageHoa(LoaiHoa lh)
        {
            InitializeComponent();
            db = new Database();
            lsthoa.ItemsSource = db.LayDSHoaTheoLoai(lh);
            Title = lh.MaLoai.ToString();
        }
    }
}