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
    public partial class PagePicker : ContentPage
    {
        public PagePicker()
        {
            InitializeComponent();
            pickerloaihoa.ItemsSource = LoaiHoa.KhoiTao();
        }
        void LayDsHoaTheoLoai(LoaiHoa lh)
        {
            List<Hoa> dshoa = new List<Hoa>();
            foreach(Hoa h in Hoa.KhoiTaoDSHoa())
            {
                if(h.MaLoai == lh.MaLoai)
                {
                    dshoa.Add(h);
                }
            }
            lsthoa.ItemsSource = dshoa;
        }

        private void pickerloaihoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerloaihoa.SelectedIndex >= 0)
            {
                LoaiHoa lh = (LoaiHoa)pickerloaihoa.SelectedItem;
                LayDsHoaTheoLoai(lh);
            }
        }
    }
}