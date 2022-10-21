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
    public partial class PageTabLoaiHoa : TabbedPage
    {
        Database db;

        void HienThiHoa()
        {
            db = new Database();
            foreach(LoaiHoa lh in db.LayDSLoaiHoa())
            {
                this.Children.Add(new PageCaroHoa(lh));
            }    
        }
        public PageTabLoaiHoa()
        {
            
            InitializeComponent();
            HienThiHoa();
        }
    }
}