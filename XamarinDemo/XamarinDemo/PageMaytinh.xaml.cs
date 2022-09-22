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
    public partial class PageMaytinh : ContentPage
    {
        Entry txtpheptinh;
        string toanhang1 = "", toanhang2 = "", toantu = "";
        void TaoMayTinh()
        {
            
            for (int i = 0; i < 6; i++)
            {//dinh nghia 6 dong
                gbangtinh.RowDefinitions.Add(new RowDefinition());
            }
            //DINH nghi 4 cot
            for (int i = 0; i < 4; i++)
            {
                gbangtinh.ColumnDefinitions.Add(new ColumnDefinition());
            }
            //Them entry
            txtpheptinh = new Entry();
            txtpheptinh.HorizontalTextAlignment = TextAlignment.End;
            txtpheptinh.FontSize = 30;
            gbangtinh.Children.Add(txtpheptinh, 0, 0);
            Grid.SetColumnSpan(txtpheptinh, 4);
            //them nut
            string[] chuoi = new string[] { "C", "+/-", "%", "div", "7", 
                "8", "9", "X", "4", "5", 
                "6", "-", "1", "2", "3",
                "+", "0", ".","="};
            for (int i = 0; i < chuoi.Length; i++)
            {
                Button n = new Button { Text = chuoi[i], HeightRequest = 100 };
                int dong, cot;
                cot = (i % 4);
                dong = ((int)i / 4) + 1;
                if(cot>=1 && dong == 5)
                {
                    cot++;
                }
                if (i <= 2)
                {
                    n.BackgroundColor = Color.Gray;
                }
                else if (cot == 3)
                    n.BackgroundColor = Color.Orange;
                else
                    n.BackgroundColor = Color.AntiqueWhite;
                n.Clicked += N_Clicked;
                gbangtinh.Children.Add(n, cot, dong);
                if(cot==0 && dong == 5)
                {
                    Grid.SetColumnSpan(n, 2);
                }

            } 

        }

        private void N_Clicked(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            double number = 0;
            double.TryParse(n.Text, out number);
            if(number != 0 )// chon nut so
            {
                if(toantu == "")
                {
                    toanhang1 = toanhang1 + n.Text;
                    txtpheptinh.Text = toanhang1;
                }
                else
                {
                    toanhang2 = toanhang2 + n.Text;
                    txtpheptinh.Text = toanhang2;
                }
            }
            else if(n.Text == "C")
            {
                txtpheptinh.Text = "0";
                toanhang1 = "";
                toanhang2 = "";
                toantu = "";
            }
            else if(n.Text =="+" || n.Text == "-" || n.Text == "X" || n.Text == "/")
            {
                toantu = n.Text;
            }
            else if(n.Text == "=")
            {
                double kq = 0, s1 = 0, s2 = 0;
                double.TryParse(toanhang1, out s1);
                double.TryParse(toanhang2, out s2);
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                if (toantu == "+")
                {
                    kq = s1 + s2;
                }
                else if (toantu == "-")
                {
                    kq = s1 - s2;
                }
                else if (toantu == "X")
                {
                    kq = s1 * s2;
                }
                else if (toantu == "/")
                    if (s2 != 0)
                        kq = s1 / s2;
                txtpheptinh.Text = kq.ToString();
            }
        }

        public PageMaytinh()
        {
            InitializeComponent();
            TaoMayTinh();
        }
    }
}