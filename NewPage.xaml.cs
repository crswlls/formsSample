using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formsSample
{
    public partial class NewPage : ContentPage
    {
        public NewPage ()
        {
            InitializeComponent ();
            BindingContext = App.Locator.NewVmx;
        }
    }
}

