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
    public partial class Bai1 : ContentPage
    {
        public Bai1()
        {
            InitializeComponent();
            listUIT.ItemsSource = NganhUIT.KhoiTao();
        }

        private void listUIT_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}