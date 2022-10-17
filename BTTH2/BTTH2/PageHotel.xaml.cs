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
    public partial class PageHotel : ContentPage
    {
        public PageHotel(City location)
        {
            InitializeComponent();
            Title = location.cityname;
            createlisthotel(location);
        }


        List<Hotel> listhotel = new List<Hotel>(); 
        private void createlisthotel(City location)
        {
            if(location.citycode == 1)
            {
                listhotel.Add(new Hotel
                {
                    hotelcode = 1,
                    hotelname = "Nusmile's Homestay & Travel",
                    hotelprice=340000,
                    hoteldes= "Hãy để chuyến đi của quý khách có một khởi đầu tuyệt vời khi ở lại khách sạn này, nơi có Wi-Fi miễn phí trong tất cả các phòng. Nằm ở vị trí chiến lược tại Quận Hoàn Kiếm, cho phép quý khách lui tới và gần với các điểm thu hút và tham quan địa phương. Đừng rời đi trước khi ghé thăm Phố Cổ nổi tiếng. Chỗ nghỉ 3 sao này có mát-xa giúp cho kỳ nghỉ của quý khách thêm thư thái và đáng nhớ.",
                    hotellocation= "Quận Hoàn Kiếm, Hà Nội, Việt Nam",
                    hotelimage="nusmile.jpg"
                }) ;

                listhotel.Add(new Hotel
                {
                    hotelcode = 2,
                    hotelname = "Luxury Backpackers",
                    hotelprice = 500000,
                    hoteldes = "Nằm ở vị trí trung tâm tại Quận Hoàn Kiếm của Hà Nội, chỗ nghỉ này đặt quý khách ở gần các điểm thu hút và tùy chọn ăn uống thú vị.",
                    hotellocation = "56 Ngõ Huyện, Quận Hoàn Kiếm",
                    hotelimage = "luxury.jpg"
                });

                listhotel.Add(new Hotel
                {
                    hotelcode = 3,
                    hotelname = "Hanoi Evergreen Hotel",
                    hotelprice = 210000,
                    hoteldes = "Hãy để chuyến đi của quý khách có một khởi đầu tuyệt vời khi ở lại khách sạn này, nơi có Wi-Fi miễn phí trong tất cả các phòng. Nằm ở vị trí chiến lược tại Phố Cổ, cho phép quý khách lui tới và gần với các điểm thu hút và tham quan địa phương. Đừng rời đi trước khi ghé thăm Phố Cổ nổi tiếng.",
                    hotellocation = "21 Hàng Đồng, Phường Hàng Bồ, Quận Hoàn Kiếm",
                    hotelimage = "evergreen.jpg"
                });

                listhotel.Add(new Hotel
                {
                    hotelcode = 4,
                    hotelname = "Little Charm Hostel Hà Nội",
                    hotelprice = 200000,
                    hoteldes = "Nằm ở vị trí trung tâm tại Quận Hoàn Kiếm của Hà Nội, chỗ nghỉ này đặt quý khách ở gần các điểm thu hút và tùy chọn ăn uống thú vị.",
                    hotellocation = "44 Hàng Bồ, phường Hàng Bồ, Quận Hoàn Kiếm",
                    hotelimage = "little.jpg"
                });

            }
            else if(location.citycode == 2)
            {
                listhotel.Add(new Hotel
                {
                    hotelcode = 1,
                    hotelname = "Te House",
                    hotelprice = 296000,
                    hoteldes = "Nằm ở vị trí trung tâm tại Bình Thạnh của Hồ Chí Minh, chỗ nghỉ này đặt quý khách ở gần các điểm thu hút và tùy chọn ăn uống thú vị.",
                    hotellocation = "Bình Thạnh",
                    hotelimage = "tehouse.jpg"
                });
                listhotel.Add(new Hotel
                {
                    hotelcode = 2,
                    hotelname = "Lotus Laverne Hotel",
                    hotelprice = 397000,
                    hoteldes = "Đỗ xe và Wi-Fi luôn miễn phí, vì vậy quý khách có thể giữ liên lạc, đến và đi tùy ý. Nằm ở vị trí trung tâm tại Bình Th?nh của Hồ Chí Minh, chỗ nghỉ này đặt quý khách ở gần các điểm thu hút và tùy chọn ăn uống thú vị. Đừng rời đi trước khi ghé thăm Bảo tàng Chứng tích chiến tranh nổi tiếng. Chỗ nghỉ 3 sao này có nhà hàng giúp cho kỳ nghỉ của quý khách thêm thư thái và đáng nhớ.",
                    hotellocation = "5/24 No Trang Long Street, Binh Thanh District, Bình Thạnh",
                    hotelimage = "laverne.jpg"
                });
                listhotel.Add(new Hotel
                {
                    hotelcode = 3,
                    hotelname = "HANZ Meraki Bui Vien Walking Street",
                    hotelprice = 309000,
                    hoteldes = "Hãy để chuyến đi của quý khách có một khởi đầu tuyệt vời khi ở lại khách sạn này, nơi có Wi-Fi miễn phí trong tất cả các phòng. Nằm ở vị trí chiến lược tại Quận 1, cho phép quý khách lui tới và gần với các điểm thu hút và tham quan địa phương. Đừng rời đi trước khi ghé thăm Bảo tàng Chứng tích chiến tranh nổi tiếng. Phòng tập và nhà hàng là một trong những tiện nghi đặc biệt sẽ nâng cao kỳ nghỉ của quý khách với sự tiện lợi ngay trong khuôn viên.",
                    hotellocation = "198 Bùi Viện, Quận 1, Tp. Hồ Chí Minh, Quận 1",
                    hotelimage = "hanz.jpg"
                });
            }
            else if (location.citycode == 3)
            {
                listhotel.Add(new Hotel
                {
                    hotelcode = 1,
                    hotelname = "Nam Xuan Premium Hotel",
                    hotelprice = 1261000,
                    hoteldes = "Chỗ nghỉ nằm trong bán kính 2,5 km từ Quảng trường Lâm Viên và 2,7 km từ Hồ Xuân Hương. Sân bay gần nhất là sân bay Liên Khương, cách Nam Xuan Premium Hotel 30 km, và chỗ nghỉ cung cấp dịch vụ đưa đón sân bay với một khoản phụ phí.",
                    hotellocation = "H8-H9 Nguyen Thi Nghia, KQH Cong Vien Van Hoa, Ward 02",
                    hotelimage = "namxuan.jpg"
                });
                listhotel.Add(new Hotel
                {
                    hotelcode = 2,
                    hotelname = "Bazan Hotel Dalat",
                    hotelprice = 1782000,
                    hoteldes = "Hồ Xuân Hương và Quảng trường Lâm Viên đều nằm cách Bazan Hotel Dalat 1,8 km. Sân bay gần nhất là sân bay Liên Khương, nằm trong bán kính 27 km từ chỗ nghỉ.",
                    hotellocation = "Đà Lạt, Việt Nam",
                    hotelimage = "bazan.jpg"
                });
            }
            else if (location.citycode == 4)
            {
                listhotel.Add(new Hotel
                {
                    hotelcode = 1,
                    hotelname = "Adela Boutique Hotel",
                    hotelprice = 1728000,
                    hoteldes = "Tọa lạc ở thành phố Đà Nẵng, Adela Boutique Hotel có nhà hàng, hồ bơi ngoài trời, trung tâm thể dục và quầy bar. Khách sạn 4 sao này có dịch vụ phòng, sảnh khách chung và WiFi miễn phí. Nơi đây cung cấp dịch vụ lễ tân 24 giờ, bếp chung và dịch vụ thu đổi ngoại tệ cho khách.",
                    hotellocation = "10 An Thuong 36, Đà Nẵng, Việt Nam",
                    hotelimage = "adela.jpg"
                });
                listhotel.Add(new Hotel
                {
                    hotelcode = 2,
                    hotelname = "Menora Premium Da Nang - Sea Corner Boutique",
                    hotelprice = 2082000,
                    hoteldes= "Phòng nghỉ tại Menora Premium Da Nang - Sea Corner Boutique có máy điều hòa, bàn làm việc, ấm đun nước, tủ lạnh, minibar, két an toàn, TV màn hình phẳng và phòng tắm riêng với vòi xịt/chậu rửa vệ sinh. Mỗi phòng đều được trang bị ga trải giường và khăn tắm.",
                    hotellocation = "196 Tran Bach Dang Street, My An Ward, Ngu Hanh Son District",
                    hotelimage = "menora.png"
                });
            }
            listHotel.ItemsSource = listhotel;
        }
        private void listHotel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender != null)
            {
                Hotel hotel = (Hotel)listHotel.SelectedItem;
                Navigation.PushAsync(new PageHotelDetail(hotel));
            }
        }
    }
}