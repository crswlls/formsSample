using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formsSample
{
    public partial class MyPage : ContentPage
    {
        public MyPage ()
        {
            InitializeComponent ();
            BindingContext = App.Locator.Main;
        }
    }
}

