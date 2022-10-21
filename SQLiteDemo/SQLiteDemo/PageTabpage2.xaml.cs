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
    public partial class PageTabpage2 : TabbedPage
    {
        public PageTabpage2()
        {
            InitializeComponent();
            this.Children.Add(new PageDangKy());
            this.Children.Add(new PageDangNhap());
        }
    }
}