using System;

using Xamarin.Forms;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GalaSoft.MvvmLight.Ioc;

namespace formsSample
{
    public class App : Application
    {
        private static ViewModelLocator _locator;
 
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
     
     
        public static Page GetMainPage()
        {
            return new MyPage();
        }

        public App ()
        {
            /*// The root page of your application
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };*/

            var nav = new NavigationService();
            nav.Configure(nameof(NewViewModel), typeof(NewPage));
            nav.Configure(nameof(MainViewModel), typeof(MyPage));
            nav.Configure(nameof(NativelyRenderedViewModel), typeof(NativelyRenderedPage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var page = new NavigationPage(GetMainPage());
            nav.Initialize(page);

            MainPage = page;
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }


    }
}

