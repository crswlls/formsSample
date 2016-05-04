using System;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace formsSample
{
    public class MyListViewModel : ViewModelBase
    {
        public ObservableCollection<SomeData> MyData { get;private set;}

        public MyListViewModel()
        {
            MyData = new ObservableCollection<SomeData>();
            MyData.Add(new SomeData("First", "This is the first", "1:10", "15 items", DataType.One, new Uri("https://avatars0.githubusercontent.com/u/8006795?v=3&s=64")));
            MyData.Add(new SomeData("Second", "This is the second", "10mins", "1 item", DataType.Two, new Uri("https://developer.xamarin.com/guides/xamarin-forms/themes/Images/Preview.png")));
            MyData.Add(new SomeData("Third", "This is the third", "1min", "1 item", DataType.Three, new Uri("https://avatars0.githubusercontent.com/u/8006795?v=3&s=64")));
            MyData.Add(new SomeData("First", "This is the first", "1:10", "15 items", DataType.One, new Uri("https://avatars0.githubusercontent.com/u/8006795?v=3&s=64")));
            MyData.Add(new SomeData("Second", "This is the second", "10mins", "1 item", DataType.Two, new Uri("https://developer.xamarin.com/guides/xamarin-forms/themes/Images/Preview.png")));
            MyData.Add(new SomeData("Third", "This is the third", "1min", "1 item", DataType.Three, new Uri("https://avatars0.githubusercontent.com/u/8006795?v=3&s=64")));

            MyData.Add(new SomeData("First", "This is the first", "1:10", "15 items", DataType.One, new Uri("https://avatars0.githubusercontent.com/u/8006795?v=3&s=64")));
            MyData.Add(new SomeData("Second", "This is the second", "10mins", "1 item", DataType.Two, new Uri("https://developer.xamarin.com/guides/xamarin-forms/themes/Images/Preview.png")));
            MyData.Add(new SomeData("Third", "This is the third", "1min", "1 item", DataType.Three, new Uri("https://avatars0.githubusercontent.com/u/8006795?v=3&s=64")));

        }
    }
}

