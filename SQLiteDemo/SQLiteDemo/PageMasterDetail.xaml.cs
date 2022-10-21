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
    public partial class PageMasterDetail : MasterDetailPage
    {
        public PageMasterDetail()
        {
            InitializeComponent();
            //Hien thi Master
            IsPresented = true;
        }

        private void cmdLoaiHoa_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageLoaiHoa());
            //khi chon thi dong Master
            IsPresented = false;
        }

        private void cmdCapNhat_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage());
            //khi chon thi dong Master
            IsPresented = false;
        }

        private void cmdLoaiHoa1_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageMasterDetailHoa());
            //khi chon thi dong Master
            IsPresented = false;
        }

        private void cmdTabpage1_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageTabpage1());
            //khi chon thi dong Master
            IsPresented = false;
        }

        private void cmdTabpage2_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageTabpage2());
            //khi chon thi dong Master
            IsPresented = false;
        }

        private void cmdTabpage3_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageTabLoaiHoa());
            //khi chon thi dong Master
            IsPresented = false;
        }
    }
}