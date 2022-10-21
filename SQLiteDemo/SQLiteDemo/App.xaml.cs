using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteDemo
{

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Database db = new Database();
            db.CreateDB();
            /*Chay 1 lan*/
/*            foreach (Hoa h in Hoa.KhoiTaoDSHoa())
                db.InsertHoa(h);*/
            MainPage = new NavigationPage( new PageMasterDetail());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
