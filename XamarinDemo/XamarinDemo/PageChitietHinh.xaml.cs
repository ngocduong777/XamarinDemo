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
    public partial class PageChitietHinh : ContentPage
    {
        public PageChitietHinh()
        {
            InitializeComponent();
        }
        public PageChitietHinh(ImageSource h)
        {
            InitializeComponent();
            this.Title = h.ToString();
            hinh.Source = h;
        }
    }
}