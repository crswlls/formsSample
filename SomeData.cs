using System;

namespace formsSample
{
    public class SomeData
    {
        public SomeData(string title, string subtitle, string moreData1, string moreData2, DataType dataType, Uri imageUri)
        {
            Title = title;
            Subtitle = subtitle;
            MoreData1 = moreData1;
            MoreData2 = moreData2;
            DataType = dataType;
            ImageUri = imageUri;
        }

        public string Title { get; private set; }
        public string Subtitle { get;private set;}
        public string MoreData1 { get;private set;}
        public string MoreData2 { get;private set;}
        public DataType DataType { get;private set;}
        public Uri ImageUri { get;private set;}
    }
}

