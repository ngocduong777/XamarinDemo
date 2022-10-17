using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageHotelDetail : ContentPage
    {
        public PageHotelDetail()
        {
            InitializeComponent();
        }
        public PageHotelDetail(Hotel hotel)
        {
            InitializeComponent();
            Title = hotel.hotelname;
            hoteldes.Text = hotel.hoteldes;
            hotelname.Text = hotel.hotelname;
            hotelimage.Source = hotel.hotelimage;
            hotelprice.Text = hotel.hotelprice.ToString();
        }
    }
}