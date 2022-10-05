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
    public partial class PageHoa : ContentPage
    {
        public PageHoa()
        {
            InitializeComponent();
            lsthoa.ItemsSource = Hoa.KhoiTaoDSHoa();
        }
        void LayDsHoaTheoLoai(LoaiHoa lh)
        {
            List<Hoa> dsHoa = new List<Hoa>();
            foreach(Hoa h in Hoa.KhoiTaoDSHoa())
            {
                if (h.MaLoai == lh.MaLoai)
                    dsHoa.Add(h);
            }
            lsthoa.ItemsSource = dsHoa;
            this.Title = lh.TenLoai;
        }
        public PageHoa(LoaiHoa lh)
        {
            InitializeComponent();
            LayDsHoaTheoLoai(lh);
        }
    }
}