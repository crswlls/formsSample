using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formsSample
{
    public partial class MyList : ContentPage
    {
        public MyList ()
        {
            InitializeComponent ();
            BindingContext = App.Locator.NewVm;
        }
    }
}

