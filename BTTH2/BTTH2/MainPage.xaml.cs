﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai1());
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai2());
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai3());
        }
    }
}