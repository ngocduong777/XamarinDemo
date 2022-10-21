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
    public partial class PageCaroHoa : CarouselPage
    {
        Database db;
        public PageCaroHoa()
        {
            InitializeComponent();
        }
        public PageCaroHoa(LoaiHoa lh)
        {
            InitializeComponent();
            db = new Database();
            this.ItemsSource = db.LayDSHoaTheoLoai(lh);
            Title = lh.TenLoai;
            IconImageSource = lh.Hinh;
        }
    }
}